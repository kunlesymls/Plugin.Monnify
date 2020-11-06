using Newtonsoft.Json;

using Plugin.Monnify.DisbursmentApi;
using Plugin.Monnify.InvoiceApi;
using Plugin.Monnify.LimitProfileApi;
using Plugin.Monnify.ReserveAccountApi;
using Plugin.Monnify.SubAccountApi;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Monnify
{
    public class MonnifyConnect
    {
        private string DefaultUrl { get; set; }
        private string ApiKey { get; set; }
        private string SecrectKey { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpire { get; set; }
        public HttpClient Client { get; set; }
        public MonnifyConnect(string apkiKey, string secrectKey, string baseUrl)
        {
            DefaultUrl = baseUrl;
            ApiKey = apkiKey;
            SecrectKey = secrectKey;

            Client = BasicAuthentication();
        }

        private async Task<T> PostUrlAndDeSerialze<T>(string url)
        {
            var result = await Client.PostAsync(url, new StringContent("", Encoding.UTF8, "application/json"));

            // Read the result as string
            var content = await result.Content.ReadAsStringAsync();

            // De-Serialize content to match the object for return
            return JsonConvert.DeserializeObject<T>(content);
        }

        private async Task<T> PostUrlAndDeSerialze<T, R>(string url, R r)
        {
            var result = await Client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(r), Encoding.UTF8, "application/json"));

            // Read the result as string
            var content = await result.Content.ReadAsStringAsync();

            // De-Serialize content to match the object for return
            return JsonConvert.DeserializeObject<T>(content);
        }

        private async Task<T> PutUrlAndDeSerialze<T, R>(string url, R r)
        {
            var result = await Client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(r), Encoding.UTF8, "application/json"));

            // Read the result as string
            var content = await result.Content.ReadAsStringAsync();

            // De-Serialize content to match the object for return
            return JsonConvert.DeserializeObject<T>(content);
        }

        private async Task<T> GetUrlAndDeSerialze<T>(string url)
        {
            var result = await Client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
        private async Task<T> DeleteUrlAndDeSerialze<T>(string url)
        {
            var result = await Client.DeleteAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public string ComputeTransactionHash(string paymentReference, string amountPaid, string paidOn, string transactionReference)
        {
            string hash_string = $"{SecrectKey}|{paymentReference}|{amountPaid}|{paidOn}|{transactionReference}";
            System.Security.Cryptography.SHA512Managed sha512 = new System.Security.Cryptography.SHA512Managed();
            byte[] EncryptedSHA512 = sha512.ComputeHash(Encoding.UTF8.GetBytes(hash_string));
            sha512.Clear();
            return BitConverter.ToString(EncryptedSHA512).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Basic authentication is a simple authentication scheme built into the HTTP protocol. 
        /// The client sends HTTP requests with the Authorization header that contains the word Basic followed by a space and a base64-encoded string apiKey:clientSecret.
        /// </summary>
        /// <returns></returns>
        private HttpClient BasicAuthentication()
        {
            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ApiKey}:{SecrectKey}")));
            var _client = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue }
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return _client;
        }

        /// <summary>
        /// Some endpoints require a bearer token for authorization. 
        /// To get a bearer token, call the login endpoint with your basic authorization header and an access token will be returned.
        /// </summary>
        /// <returns>AuthenticationResponse</returns>
        public async Task<AuthenticationResponse> GetBearerAccessToken()
        {
            string url = $"{DefaultUrl}auth/login/";
            var response = await PostUrlAndDeSerialze<AuthenticationResponse>(url);
            Token = response.ResponseBody.accessToken;
            TokenExpire = DateTime.Parse(response.ResponseBody.ExpiresIn);
            return response;
        }

        public async Task<OneTimeTransactionResponse> InitiateOneTimeTransaction(OneTimeTransactionRequest request)
        {
            string url = DefaultUrl + "merchant/transactions/init-transaction";
            return await PostUrlAndDeSerialze<OneTimeTransactionResponse, OneTimeTransactionRequest>(url, request);
        }

        /// <summary>
        /// Monnify invoicing allows you generate invoices via APIs. For each invoice, 
        /// we will generate a virtual account number tied to that invoice so your customers can simply transfer to that account number to pay. 
        /// We will also return a checkout URL so your customers can pay via their Debit Cards
        /// </summary>
        /// <param name="request"></param>
        /// <returns>InvoiceResponse</returns>
        public async Task<InvoiceResponse> CreateInvoice(InvoiceRequest request)
        {
            string url = DefaultUrl + "invoice/create";
            return await PostUrlAndDeSerialze<InvoiceResponse, InvoiceRequest>(url, request);
        }

        /// <summary>
        /// Get the Invoice Detail by invoice reference number
        /// </summary>
        /// <param name="request">InvoiceDetailRequest</param>
        /// <returns>InvoiceResponse</returns>
        public async Task<InvoiceResponse> GetInvoiceDetail(InvoiceDetailRequest request)
        {
            string url = $"{DefaultUrl}invoice/details?{request.InvoiceReference}";
            return await GetUrlAndDeSerialze<InvoiceResponse>(url);
        }

        /// <summary>
        /// Getting all response 
        /// </summary>
        /// <returns>AllInvoiceResponse</returns>
        public async Task<AllInvoiceResponse> GetAllInvoices()
        {
            string url = $"{DefaultUrl}invoice/all";
            return await GetUrlAndDeSerialze<AllInvoiceResponse>(url);
        }

        /// <summary>
        /// Can Invoice by Invoice Reference number
        /// </summary>
        /// <param name="request">InvoiceDetailRequest</param>
        /// <returns>InvoiceResponse</returns>
        public async Task<InvoiceResponse> CancelInvoiceRequest(InvoiceDetailRequest request)
        {
            string url = $"{DefaultUrl}invoice/cancel?invoiceReference={request.InvoiceReference}";
            return await GetUrlAndDeSerialze<InvoiceResponse>(url);
        }

        /// <summary>
        /// Verification of Transactions by Payment Reference
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransactionStatusResponse</returns>
        public async Task<TransactionStatusResponse> VerifyTransactionByPaymentReference(TransactionStatusRequest request)
        {
            string url = $"{DefaultUrl}merchant/transactions/query?paymentReference={request.PaymentReference}";
            return await GetUrlAndDeSerialze<TransactionStatusResponse>(url);
        }

        /// <summary>
        /// Verification of Transactions by Transaction Reference
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransactionStatusResponse</returns>
        public async Task<TransactionStatusResponse> VerifyTransactionByTransactionReference(TransactionStatusRequest request)
        {
            string url = $"{DefaultUrl}merchant/transactions/query?transactionReference={request.TransactionReference}";
            return await GetUrlAndDeSerialze<TransactionStatusResponse>(url);
        }

        /// <summary>
        /// Monnify allows you Reserve an Account for your customers who you send invoices to. 
        /// You can then attach these accounts to invoices being generated so the customer always receives the same account number for any invoice he receives.
        /// Basically, the account number is only active when attached to an invoice.
        /// </summary>
        /// <param name="request">CreateInvoiceReserveAccountRequest</param>
        /// <returns>CreateReserveAccountResponse</returns>
        public async Task<CreateReserveAccountResponse> CreateInvoiceReserveAccount(CreateInvoiceReserveAccountRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/";
            return await PostUrlAndDeSerialze<CreateReserveAccountResponse, CreateInvoiceReserveAccountRequest>(url, request);
        }

        /// <summary>
        /// Post request to reserve account for customer
        /// Reserved account APIs enable merchants create accounts that can be dedicated to each of their customers. 
        /// Once any payment is done to that account, we notify your webhook with the payment information
        /// </summary>
        /// <param name="request">CreateReserveAccountRequest</param>
        /// <returns>CreateReserveAccountResponse</returns>
        public async Task<CreateReserveAccountResponse> ReserveAccount(CreateReserveAccountRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts";
            return await PostUrlAndDeSerialze<CreateReserveAccountResponse, CreateReserveAccountRequest>(url, request);
        }


        /// <summary>
        /// Get Reserved Account Transactions
        /// Reserved account APIs enable merchants create accounts that can be dedicated to each of their customers. 
        /// Once any payment is done to that account, we notify your webhook with the payment information
        /// </summary>
        /// <param name="request">GetReserveAccountRequest</param>
        /// <returns>GetReserveAccountResponse</returns>
        public async Task<GetReserveAccountTransactionResponse> ReserveAccountTransctions(GetReserveAccountTransactionRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/transactions?accountReference={request.AccountReference}&page={request.Page}&size={request.Size}";
            return await GetUrlAndDeSerialze<GetReserveAccountTransactionResponse>(url);
        }


        /// <summary>
        /// Get Reserved Account 
        /// Reserved account APIs enable merchants create accounts that can be dedicated to each of their customers. 
        /// Once any payment is done to that account, we notify your webhook with the payment information
        /// </summary>
        /// <param name="request">GetReserveAccountRequest</param>
        /// <returns>GetReserveAccountResponse</returns>
        public async Task<GetReserveAccountResponse> GetReserveAccountDetail(ReserveAccountRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/{request.AccountReference}";
            return await GetUrlAndDeSerialze<GetReserveAccountResponse>(url);
        }

        /// <summary>
        /// Delete Reserved Account 
        /// Reserved account APIs enable merchants create accounts that can be dedicated to each of their customers. 
        /// Once any payment is done to that account, we notify your webhook with the payment information
        /// </summary>
        /// <param name="request">GetReserveAccountRequest</param>
        /// <returns>GetReserveAccountResponse</returns>
        public async Task<DeleteReserveAccountResponse> DeleteReserveAccount(ReserveAccountRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/{request.AccountReference}";
            return await DeleteUrlAndDeSerialze<DeleteReserveAccountResponse>(url);
        }



        /// <summary>
        /// Add a sub account for Merchant
        /// With sub accounts, you can easily split a single payment across multiple accounts. 
        /// This means for one transaction, Monnify can help you share the amount paid between up to 5 different accounts.
        /// </summary>
        /// <param name="request">CreateSubAccountRequest</param>
        /// <returns>CreateSubAccountResponse</returns>
        public async Task<CreateSubAccountResponse> AddSubAccount(CreateSubAccountRequest request)
        {
            string url = $"{DefaultUrl}sub-accounts";
            return await PostUrlAndDeSerialze<CreateSubAccountResponse, CreateSubAccountRequest>(url, request);
        }

        /// <summary>
        /// Get All Sub-Accounts
        /// With sub accounts, you can easily split a single payment across multiple accounts. 
        /// This means for one transaction, Monnify can help you share the amount paid between up to 5 different accounts
        /// </summary>
        /// <returns>CreateSubAccountResponse</returns>
        public async Task<CreateSubAccountResponse> GetSubAccounts()
        {
            string url = $"{DefaultUrl}sub-accounts";
            return await GetUrlAndDeSerialze<CreateSubAccountResponse>(url);
        }

        /// <summary>
        /// Update Sub-Account
        /// With sub accounts, you can easily split a single payment across multiple accounts. 
        /// This means for one transaction, Monnify can help you share the amount paid between up to 5 different accounts
        /// </summary>
        /// <param name="request"></param>
        /// <returns>EditSubAccountResponse</returns>
        public async Task<EditSubAccountResponse> UpdateSubAccount(EditSubAccountRequest request)
        {
            string url = $"{DefaultUrl}sub-accounts";
            return await PutUrlAndDeSerialze<EditSubAccountResponse, EditSubAccountRequest>(url, request);
        }

        /// <summary>
        /// Remove Sub-Account
        /// With sub accounts, you can easily split a single payment across multiple accounts. 
        /// This means for one transaction, Monnify can help you share the amount paid between up to 5 different accounts
        /// </summary>
        /// <param name="request"></param>
        /// <returns>EditSubAccountResponse</returns>
        public async Task<EditSubAccountResponse> DeleteSubAccount(DeleteSubAccountRequest request)
        {
            string url = $"{DefaultUrl}sub-accounts/?subAccountCode={request.SubAccountCode}";
            return await DeleteUrlAndDeSerialze<EditSubAccountResponse>(url);
        }


        /// <summary>
        /// Add Limit Profile
        /// Creates a Limit Profile for a merchant. Allowing the merchant to set a limit on a customer's reserved account.
        /// Once the request is sent, a Limit Profile code will be returned
        /// </summary>
        /// <param name="request"></param>
        /// <returns>CreateLimitProfileResponse</returns>
        public async Task<CreateLimitProfileResponse> AddLimitProfile(CreateLimitProfileRequest request)
        {
            string url = $"{DefaultUrl}limit-profile/";
            return await PostUrlAndDeSerialze<CreateLimitProfileResponse, CreateLimitProfileRequest>(url, request);
        }

        /// <summary>
        /// Get all Limit Profiles
        /// The transaction limit APIs allows the merchant to set a limit on a customer's account. 
        /// This means a merchant can set the maximum amount per transaction, the maximum number of transactions per day, and the total amount per day on a customer's account.
        /// </summary>
        /// <returns>CreateLimitProfileResponses</returns>
        public async Task<CreateLimitProfileResponses> GetLimitProfiles()
        {
            string url = $"{DefaultUrl}limit-profile/";
            return await GetUrlAndDeSerialze<CreateLimitProfileResponses>(url);
        }

        /// <summary>
        /// Updates a Limit Profile for a merchant. Allowing the merchant to set a limit on a customer's reserved account.
        /// Once the request is sent, a Limit Profile code will be returned
        /// </summary>
        /// <param name="request"></param>
        /// <returns>CreateLimitProfileResponse</returns>
        public async Task<CreateLimitProfileResponse> UpdateLimitProfile(CreateLimitProfileRequest request)
        {
            string url = $"{DefaultUrl}sub-accounts";
            return await PutUrlAndDeSerialze<CreateLimitProfileResponse, CreateLimitProfileRequest>(url, request);
        }

        /// <summary>
        /// Reserve Account with Profile Limit
        /// The limit profile code is mandatory for accounts with a limit associated with the limit profile
        /// This endpoint allows you to reserve an account and associate it with a limit profile
        /// </summary>
        /// <param name="request"></param>
        /// <returns>ReserveAccountWithLimitResponse</returns>
        public async Task<ReserveAccountWithLimitResponse> ReserveAccountWithLimit(ReserveAccountWithLimitRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/";
            return await PostUrlAndDeSerialze<ReserveAccountWithLimitResponse, ReserveAccountWithLimitRequest>(url, request);
        }
        /// <summary>
        /// Update Account with Profile Limit
        /// The limit profile code is mandatory for accounts with a limit associated with the limit profile
        /// This endpoint allows you to reserve an account and associate it with a limit profile
        /// </summary>
        /// <param name="request"></param>
        /// <returns>ReserveAccountWithLimitResponse</returns>
        public async Task<ReserveAccountWithLimitResponse> UpdateReserveAccountWithLimit(UpdateReserveAccountWithLimitRequest request)
        {
            string url = $"{DefaultUrl}bank-transfer/reserved-accounts/";
            return await PostUrlAndDeSerialze<ReserveAccountWithLimitResponse, UpdateReserveAccountWithLimitRequest>(url, request);
        }

        /// <summary>
        /// Single Transfer
        /// The Monnify Disbursements APIs allow a merchant to initiate payouts from his Monnify Wallet to any bank account in Nigeria
        /// If the merchant does not have Two Factor Authentication (2FA) enabled, the transaction will be processed instantly as in the response. 
        /// If 2FA is enabled, the response will indicate stutus as pending authorization
        /// </summary>
        /// <param name="request"></param>
        /// <returns>SingleTransferResponse</returns>
        public async Task<SingleTransferResponse> InitiateSingleTransfer(SingleTransferRequest request)
        {
            string url = $"{DefaultUrl}disbursements/single";
            return await PostUrlAndDeSerialze<SingleTransferResponse, SingleTransferRequest>(url, request);
        }

        /// <summary>
        /// Bulk Transfer
        /// The Monnify Disbursements APIs allow a merchant to initiate payouts from his Monnify Wallet to any bank account in Nigeria
        /// If the merchant does not have Two Factor Authentication (2FA) enabled, the transaction will be processed instantly as in the response. 
        /// If 2FA is enabled, the response will indicate stutus as pending authorization
        /// </summary>
        /// <param name="request"></param>
        /// <returns>BulkTransferResponse</returns>
        public async Task<BulkTransferResponse> InitiateBulkTransfer(BulkTransferRequest request)
        {
            string url = $"{DefaultUrl}disbursements/batch";
            return await PostUrlAndDeSerialze<BulkTransferResponse, BulkTransferRequest>(url, request);
        }
        /// <summary>
        /// Authorize single transfer via OTP
        /// </summary>
        /// <param name="request"></param>
        /// <returns>SingleTransferResponse</returns>
        public async Task<SingleTransferResponse> AuthorizeSingleTransfer(AuthorizeTransferRequest request)
        {
            string url = $"{DefaultUrl}disbursements/single/validate-otp";
            return await PostUrlAndDeSerialze<SingleTransferResponse, AuthorizeTransferRequest>(url, request);
        }

        /// <summary>
        /// Authorize bulk transfer via OTP
        /// </summary>
        /// <param name="request"></param>
        /// <returns>SingleTransferResponse</returns>
        public async Task<SingleTransferResponse> AuthorizeBatchTransfer(AuthorizeTransferRequest request)
        {
            string url = $"{DefaultUrl}disbursements/batch/validate-otp";
            return await PostUrlAndDeSerialze<SingleTransferResponse, AuthorizeTransferRequest>(url, request);
        }

        /// <summary>
        /// Request for OTP to be resend
        /// </summary>
        /// <param name="request"></param>
        /// <returns>ResendOTPResponse</returns>
        public async Task<ResendOTPResponse> ResendOTP(TransactionRequest request)
        {
            string url = $"{DefaultUrl}disbursements/single/resend-otp";
            return await PostUrlAndDeSerialze<ResendOTPResponse, TransactionRequest>(url, request);
        }

        /// <summary>
        /// Get the detail for single transfer
        /// </summary>
        /// <param name="request"></param>
        /// <returns>SingleTransferDetailResponse</returns>
        public async Task<SingleTransferDetailResponse> GetSingleTransfer(TransactionRequest request)
        {
            string url = $"{DefaultUrl}disbursements/single/summary?reference={request.Reference}";
            return await GetUrlAndDeSerialze<SingleTransferDetailResponse>(url);
        }

        /// <summary>
        /// Get the detail for bulk transfer
        /// </summary>
        /// <param name="request"></param>
        /// <returns>BatchTransferDetailResponse</returns>
        public async Task<BatchTransferDetailResponse> GetBulkTransfer(TransactionRequest request)
        {
            string url = $"{DefaultUrl}disbursements/batch/summary?reference={request.Reference}";
            return await GetUrlAndDeSerialze<BatchTransferDetailResponse>(url);
        }

        /// <summary>
        /// Get the detail for bulk transfer with paging 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>BatchTransactionResponse</returns>
        public async Task<BatchTransactionResponse> GetBulkTransferWithPaging(TransactionRequest request)
        {
            string url = $"{DefaultUrl}disbursements/bulk//transactions?batchReference={request.Reference}";
            return await GetUrlAndDeSerialze<BatchTransactionResponse>(url);
        }

        /// <summary>
        /// Get the detail for single transfer with paging 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>BatchTransactionResponse</returns>
        public async Task<BatchTransactionResponse> GetAllSingleTransfer(int pageSize)
        {
            string url = $"{DefaultUrl}disbursements/single/transactions?pageSize={pageSize}";
            return await GetUrlAndDeSerialze<BatchTransactionResponse>(url);
        }

        /// <summary>
        /// Get the detail for all bulk transfer with paging 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>BulkTransferResponses</returns>
        public async Task<BulkTransferResponses> GetBulkTransfers(int pageSize)
        {
            string url = $"{DefaultUrl}disbursements/bulk/transactions?pageSize={pageSize}";
            return await GetUrlAndDeSerialze<BulkTransferResponses>(url);
        }

        /// <summary>
        /// Get your wallet balance 
        /// </summary>
        /// <param name="walletId"></param>
        /// <returns>GetWalletBalanceResponse</returns>
        public async Task<GetWalletBalanceResponse> GetWalletBalance(string walletId)
        {
            string url = $"{DefaultUrl}disbursements/wallet-balance?walletId={walletId}";
            return await GetUrlAndDeSerialze<GetWalletBalanceResponse>(url);
        }

        /// <summary>
        /// Validate your customers account number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="bankCode"></param>
        /// <returns>ValidateBankAccount</returns>
        public async Task<GetBankAccountResponse> ValidateBankAccount(string accountNumber, string bankCode)
        {
            string url = $"{DefaultUrl}disbursements/account/validate?accountNumber={accountNumber}&bankCode={bankCode}";
            return await GetUrlAndDeSerialze<GetBankAccountResponse>(url);
        }
    }
}

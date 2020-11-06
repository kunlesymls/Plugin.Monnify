using Plugin.Monnify.DisbursmentApi;
using Plugin.Monnify.InvoiceApi;
using Plugin.Monnify.LimitProfileApi;
using Plugin.Monnify.ReserveAccountApi;
using Plugin.Monnify.SubAccountApi;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plugin.Monnify
{
    public interface IMonnifyClient
    {
        HttpClient Client { get; set; }
        string Token { get; set; }
        DateTime TokenExpire { get; set; }

        void ConfigureMonnifyClient(string apkiKey, string secrectKey);
        Task<CreateLimitProfileResponse> AddLimitProfile(CreateLimitProfileRequest request);
        Task<CreateSubAccountResponse> AddSubAccount(CreateSubAccountRequest request);
        Task<SingleTransferResponse> AuthorizeBatchTransfer(AuthorizeTransferRequest request);
        Task<SingleTransferResponse> AuthorizeSingleTransfer(AuthorizeTransferRequest request);
        Task<InvoiceResponse> CancelInvoiceRequest(InvoiceDetailRequest request);
        string ComputeTransactionHash(string paymentReference, string amountPaid, string paidOn, string transactionReference);
        Task<InvoiceResponse> CreateInvoice(InvoiceRequest request);
        Task<CreateReserveAccountResponse> CreateInvoiceReserveAccount(CreateInvoiceReserveAccountRequest request);
        Task<DeleteReserveAccountResponse> DeleteReserveAccount(ReserveAccountRequest request);
        Task<EditSubAccountResponse> DeleteSubAccount(DeleteSubAccountRequest request);
        Task<AllInvoiceResponse> GetAllInvoices();
        Task<BatchTransactionResponse> GetAllSingleTransfer(int pageSize);
        Task<AuthenticationResponse> GetBearerAccessToken();
        Task<BatchTransferDetailResponse> GetBulkTransfer(TransactionRequest request);
        Task<BulkTransferResponses> GetBulkTransfers(int pageSize);
        Task<BatchTransactionResponse> GetBulkTransferWithPaging(TransactionRequest request);
        Task<InvoiceResponse> GetInvoiceDetail(InvoiceDetailRequest request);
        Task<CreateLimitProfileResponses> GetLimitProfiles();
        Task<GetReserveAccountResponse> GetReserveAccountDetail(ReserveAccountRequest request);
        Task<SingleTransferDetailResponse> GetSingleTransfer(TransactionRequest request);
        Task<CreateSubAccountResponse> GetSubAccounts();
        Task<GetWalletBalanceResponse> GetWalletBalance(string walletId);
        Task<BulkTransferResponse> InitiateBulkTransfer(BulkTransferRequest request);
        Task<OneTimeTransactionResponse> InitiateOneTimeTransaction(OneTimeTransactionRequest request);
        Task<SingleTransferResponse> InitiateSingleTransfer(SingleTransferRequest request);
        Task<ResendOTPResponse> ResendOTP(TransactionRequest request);
        Task<CreateReserveAccountResponse> ReserveAccount(CreateReserveAccountRequest request);
        Task<GetReserveAccountTransactionResponse> ReserveAccountTransctions(GetReserveAccountTransactionRequest request);
        Task<ReserveAccountWithLimitResponse> ReserveAccountWithLimit(ReserveAccountWithLimitRequest request);
        Task<CreateLimitProfileResponse> UpdateLimitProfile(CreateLimitProfileRequest request);
        Task<ReserveAccountWithLimitResponse> UpdateReserveAccountWithLimit(UpdateReserveAccountWithLimitRequest request);
        Task<EditSubAccountResponse> UpdateSubAccount(EditSubAccountRequest request);
        Task<GetBankAccountResponse> ValidateBankAccount(string accountNumber, string bankCode);
        Task<TransactionStatusResponse> VerifyTransactionByPaymentReference(TransactionStatusRequest request);
        Task<TransactionStatusResponse> VerifyTransactionByTransactionReference(TransactionStatusRequest request);
    }
}
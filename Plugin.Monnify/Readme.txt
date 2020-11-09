Readme File for Plugin.Monnify nuget package

===========================================================

Please refer to https://github.com/kunlesymls/Plugin.Monnify.Demo for examples and demo of how to use this package.

============================================================
Store your keys in the appsetting.json file like this

"MonnifyUrl": {
    "BaseUrl": "https://sandbox.monnify.com/api/v1/",
    "ApiKey": "",
    "SecretKey": "",
    "ContractCode": ""
  }

===========================================================

Register this service in the Startup.cs file

  services.AddSingleton<IMonnifyClient>(x => new MonnifyClient(
    new MonnifySetting
    {
        BaseUrl = Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
        ApiKey = Configuration.GetValue<string>("MonnifyUrl:ApiKey"),
        SecretKey = Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
        ContractCode = Configuration.GetValue<string>("MonnifyUrl:ContractCode")
    }));

    OR

     services.AddScoped<IMonnifyClient>(x => 
            new MonnifyClient(baseUrl:Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
            apiKey: Configuration.GetValue<string>("MonnifyUrl:ApiKey"), 
            secretKey: Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
            contractCode:Configuration.GetValue<string>("MonnifyUrl:ContractCode")));

 ========================================================

 If you are not using DI
 just instantiate the class by 

 new MonnifyClient(baseUrl:Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
            apiKey: Configuration.GetValue<string>("MonnifyUrl:ApiKey"), 
            secretKey: Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
            contractCode:Configuration.GetValue<string>("MonnifyUrl:ContractCode"))

OR

new MonnifyClient(
    new MonnifySetting
    {
        BaseUrl = Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
        ApiKey = Configuration.GetValue<string>("MonnifyUrl:ApiKey"),
        SecretKey = Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
        ContractCode = Configuration.GetValue<string>("MonnifyUrl:ContractCode")
    })

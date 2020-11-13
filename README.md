# Monnify API for .Net
Monnify API for .Net
This library makes it easy to consume the Payment API from .Net projects.

# How to install
From nuget
```
Install-Package Plugin.Monnify

```

# Usage
Store your keys in the appsetting.json file like this
```
"MonnifyUrl": {
    "BaseUrl": "https://sandbox.monnify.com/",
    "ApiKey": "",
    "SecretKey": "",
    "ContractCode": ""
  }
 ```
 
 Register this service in the Startup.cs file
 ``` 
  services.AddSingleton<IMonnifyClient>(x => new MonnifyClient(
    new MonnifySetting
    {
        BaseUrl = Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
        ApiKey = Configuration.GetValue<string>("MonnifyUrl:ApiKey"),
        SecretKey = Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
        ContractCode = Configuration.GetValue<string>("MonnifyUrl:ContractCode")
    }));
  
 ```
 OR
 ```
     services.AddScoped<IMonnifyClient>(x => 
            new MonnifyClient(baseUrl:Configuration.GetValue<string>("MonnifyUrl:BaseUrl"),
            apiKey: Configuration.GetValue<string>("MonnifyUrl:ApiKey"), 
            secretKey: Configuration.GetValue<string>("MonnifyUrl:SecretKey"),
            contractCode:Configuration.GetValue<string>("MonnifyUrl:ContractCode")));
 ```

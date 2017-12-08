# IO.Swagger - the C# library for the Lending Club API

Lending Club API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                AvailableCash result = apiInstance.AvailableCash(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AvailableCash: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**AvailableCash**](docs/AccountsApi.md#availablecash) | **GET** /accounts/{investor}/availablecash | 
*AccountsApi* | [**CreatePortfolio**](docs/AccountsApi.md#createportfolio) | **POST** /accounts/{investor}/portfolios | 
*AccountsApi* | [**DetailedNotesOwned**](docs/AccountsApi.md#detailednotesowned) | **GET** /accounts/{investor}/detailednotes | 
*AccountsApi* | [**Filters**](docs/AccountsApi.md#filters) | **GET** /accounts/{investor}/filters | 
*AccountsApi* | [**NotesOwned**](docs/AccountsApi.md#notesowned) | **GET** /accounts/{investor}/notes | 
*AccountsApi* | [**PortfoliosOwned**](docs/AccountsApi.md#portfoliosowned) | **GET** /accounts/{investor}/portfolios | 
*AccountsApi* | [**SubmitOrder**](docs/AccountsApi.md#submitorder) | **POST** /accounts/{investor}/orders | 
*AccountsApi* | [**Summary**](docs/AccountsApi.md#summary) | **GET** /accounts/{investor}/summary | 
*FundsApi* | [**Add**](docs/FundsApi.md#add) | **POST** /accounts/{investor}/funds/add | 
*FundsApi* | [**Cancel**](docs/FundsApi.md#cancel) | **POST** /accounts/{investor}/funds/cancel | 
*FundsApi* | [**Pending**](docs/FundsApi.md#pending) | **GET** /accounts/{investor}/funds/pending | 
*FundsApi* | [**Withdraw**](docs/FundsApi.md#withdraw) | **POST** /accounts/{investor}/funds/withdraw | 
*LoansApi* | [**ListedLoans**](docs/LoansApi.md#listedloans) | **GET** /loans/listing | 
*TradesApi* | [**BuyNotes**](docs/TradesApi.md#buynotes) | **POST** /accounts/{investor}/trades/buy | 
*TradesApi* | [**SellNotes**](docs/TradesApi.md#sellnotes) | **POST** /accounts/{investor}/trades/sell | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountSummary](docs/AccountSummary.md)
 - [Model.Adjustments](docs/Adjustments.md)
 - [Model.ApplicationType](docs/ApplicationType.md)
 - [Model.AvailableCash](docs/AvailableCash.md)
 - [Model.BuyNote](docs/BuyNote.md)
 - [Model.BuyNoteExecutionStatus](docs/BuyNoteExecutionStatus.md)
 - [Model.BuyNotesRequest](docs/BuyNotesRequest.md)
 - [Model.BuyNotesResponse](docs/BuyNotesResponse.md)
 - [Model.CancelTransferRequest](docs/CancelTransferRequest.md)
 - [Model.CancelTransferResponse](docs/CancelTransferResponse.md)
 - [Model.CancellationResult](docs/CancellationResult.md)
 - [Model.CreatePortfolioRequest](docs/CreatePortfolioRequest.md)
 - [Model.CreditTrend](docs/CreditTrend.md)
 - [Model.DetailedNotesOwned](docs/DetailedNotesOwned.md)
 - [Model.DisbursementMethod](docs/DisbursementMethod.md)
 - [Model.ExecutionStatus](docs/ExecutionStatus.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.HomeOwnership](docs/HomeOwnership.md)
 - [Model.IncomeVerified](docs/IncomeVerified.md)
 - [Model.InitialListStatus](docs/InitialListStatus.md)
 - [Model.ListedLoan](docs/ListedLoan.md)
 - [Model.ListedLoans](docs/ListedLoans.md)
 - [Model.LoanGrade](docs/LoanGrade.md)
 - [Model.LoanStatus](docs/LoanStatus.md)
 - [Model.NetAnnualizedReturn](docs/NetAnnualizedReturn.md)
 - [Model.NewOrder](docs/NewOrder.md)
 - [Model.Note](docs/Note.md)
 - [Model.NotesOwned](docs/NotesOwned.md)
 - [Model.OrderStatus](docs/OrderStatus.md)
 - [Model.PaymentStatus](docs/PaymentStatus.md)
 - [Model.Portfolio](docs/Portfolio.md)
 - [Model.PortfoliosOwned](docs/PortfoliosOwned.md)
 - [Model.Purpose](docs/Purpose.md)
 - [Model.ReviewStatus](docs/ReviewStatus.md)
 - [Model.ScheduledTransfer](docs/ScheduledTransfer.md)
 - [Model.SellNote](docs/SellNote.md)
 - [Model.SellNoteExecutionStatus](docs/SellNoteExecutionStatus.md)
 - [Model.SellNotesRequest](docs/SellNotesRequest.md)
 - [Model.SellNotesResponse](docs/SellNotesResponse.md)
 - [Model.SellNotesStatus](docs/SellNotesStatus.md)
 - [Model.SubmitOrderRequest](docs/SubmitOrderRequest.md)
 - [Model.SubmitOrderResponse](docs/SubmitOrderResponse.md)
 - [Model.Transfer](docs/Transfer.md)
 - [Model.TransferFrequency](docs/TransferFrequency.md)
 - [Model.Transfers](docs/Transfers.md)
 - [Model.DetailedNote](docs/DetailedNote.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apiKey"></a>
### apiKey

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


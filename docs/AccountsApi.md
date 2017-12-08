# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvailableCash**](AccountsApi.md#availablecash) | **GET** /accounts/{investor}/availablecash | 
[**CreatePortfolio**](AccountsApi.md#createportfolio) | **POST** /accounts/{investor}/portfolios | 
[**DetailedNotesOwned**](AccountsApi.md#detailednotesowned) | **GET** /accounts/{investor}/detailednotes | 
[**Filters**](AccountsApi.md#filters) | **GET** /accounts/{investor}/filters | 
[**FundsAdd**](AccountsApi.md#fundsadd) | **POST** /accounts/{investor}/funds/add | 
[**FundsCancel**](AccountsApi.md#fundscancel) | **POST** /accounts/{investor}/funds/cancel | 
[**FundsPending**](AccountsApi.md#fundspending) | **GET** /accounts/{investor}/funds/pending | 
[**FundsWithdraw**](AccountsApi.md#fundswithdraw) | **POST** /accounts/{investor}/funds/withdraw | 
[**NotesOwned**](AccountsApi.md#notesowned) | **GET** /accounts/{investor}/notes | 
[**PortfoliosOwned**](AccountsApi.md#portfoliosowned) | **GET** /accounts/{investor}/portfolios | 
[**SubmitOrder**](AccountsApi.md#submitorder) | **POST** /accounts/{investor}/orders | 
[**Summary**](AccountsApi.md#summary) | **GET** /accounts/{investor}/summary | 


<a name="availablecash"></a>
# **AvailableCash**
> AvailableCash AvailableCash (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AvailableCashExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**AvailableCash**](AvailableCash.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createportfolio"></a>
# **CreatePortfolio**
> Portfolio CreatePortfolio (CreatePortfolioRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePortfolioExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var request = new CreatePortfolioRequest(); // CreatePortfolioRequest | 

            try
            {
                Portfolio result = apiInstance.CreatePortfolio(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreatePortfolioRequest**](CreatePortfolioRequest.md)|  | 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detailednotesowned"></a>
# **DetailedNotesOwned**
> DetailedNotesOwned DetailedNotesOwned (int? investor, string X_LC_DETAILED_NOTES_VERSION = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DetailedNotesOwnedExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 
            var X_LC_DETAILED_NOTES_VERSION = X_LC_DETAILED_NOTES_VERSION_example;  // string |  (optional) 

            try
            {
                DetailedNotesOwned result = apiInstance.DetailedNotesOwned(investor, X_LC_DETAILED_NOTES_VERSION);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DetailedNotesOwned: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **X_LC_DETAILED_NOTES_VERSION** | **string**|  | [optional] 

### Return type

[**DetailedNotesOwned**](DetailedNotesOwned.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filters"></a>
# **Filters**
> List<Filter> Filters (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FiltersExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                List&lt;Filter&gt; result = apiInstance.Filters(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Filters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**List<Filter>**](Filter.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fundsadd"></a>
# **FundsAdd**
> ScheduledTransfer FundsAdd (int? investor, ScheduledTransfer request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FundsAddExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 
            var request = new ScheduledTransfer(); // ScheduledTransfer | 

            try
            {
                ScheduledTransfer result = apiInstance.FundsAdd(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FundsAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **request** | [**ScheduledTransfer**](ScheduledTransfer.md)|  | 

### Return type

[**ScheduledTransfer**](ScheduledTransfer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fundscancel"></a>
# **FundsCancel**
> CancelTransferResponse FundsCancel (int? investor, CancelTransferRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FundsCancelExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 
            var request = new CancelTransferRequest(); // CancelTransferRequest | 

            try
            {
                CancelTransferResponse result = apiInstance.FundsCancel(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FundsCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **request** | [**CancelTransferRequest**](CancelTransferRequest.md)|  | 

### Return type

[**CancelTransferResponse**](CancelTransferResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fundspending"></a>
# **FundsPending**
> Transfers FundsPending (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FundsPendingExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                Transfers result = apiInstance.FundsPending(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FundsPending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**Transfers**](Transfers.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fundswithdraw"></a>
# **FundsWithdraw**
> ScheduledTransfer FundsWithdraw (int? investor, ScheduledTransfer request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FundsWithdrawExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 
            var request = new ScheduledTransfer(); // ScheduledTransfer | 

            try
            {
                ScheduledTransfer result = apiInstance.FundsWithdraw(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FundsWithdraw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **request** | [**ScheduledTransfer**](ScheduledTransfer.md)|  | 

### Return type

[**ScheduledTransfer**](ScheduledTransfer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesowned"></a>
# **NotesOwned**
> NotesOwned NotesOwned (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotesOwnedExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                NotesOwned result = apiInstance.NotesOwned(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.NotesOwned: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**NotesOwned**](NotesOwned.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfoliosowned"></a>
# **PortfoliosOwned**
> PortfoliosOwned PortfoliosOwned (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfoliosOwnedExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                PortfoliosOwned result = apiInstance.PortfoliosOwned(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.PortfoliosOwned: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**PortfoliosOwned**](PortfoliosOwned.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitorder"></a>
# **SubmitOrder**
> SubmitOrderResponse SubmitOrder (int? investor, SubmitOrderRequest orders)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitOrderExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 
            var orders = new SubmitOrderRequest(); // SubmitOrderRequest | 

            try
            {
                SubmitOrderResponse result = apiInstance.SubmitOrder(investor, orders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.SubmitOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **orders** | [**SubmitOrderRequest**](SubmitOrderRequest.md)|  | 

### Return type

[**SubmitOrderResponse**](SubmitOrderResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="summary"></a>
# **Summary**
> AccountSummary Summary (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SummaryExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var investor = 56;  // int? | 

            try
            {
                AccountSummary result = apiInstance.Summary(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Summary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 

### Return type

[**AccountSummary**](AccountSummary.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


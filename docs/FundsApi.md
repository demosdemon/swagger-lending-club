# IO.Swagger.Api.FundsApi

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FundsAdd**](FundsApi.md#fundsadd) | **POST** /accounts/{investor}/funds/add | 
[**FundsCancel**](FundsApi.md#fundscancel) | **POST** /accounts/{investor}/funds/cancel | 
[**FundsPending**](FundsApi.md#fundspending) | **GET** /accounts/{investor}/funds/pending | 
[**FundsWithdraw**](FundsApi.md#fundswithdraw) | **POST** /accounts/{investor}/funds/withdraw | 


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

            var apiInstance = new FundsApi();
            var investor = 56;  // int? | 
            var request = new ScheduledTransfer(); // ScheduledTransfer | 

            try
            {
                ScheduledTransfer result = apiInstance.FundsAdd(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.FundsAdd: " + e.Message );
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

            var apiInstance = new FundsApi();
            var investor = 56;  // int? | 
            var request = new CancelTransferRequest(); // CancelTransferRequest | 

            try
            {
                CancelTransferResponse result = apiInstance.FundsCancel(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.FundsCancel: " + e.Message );
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

            var apiInstance = new FundsApi();
            var investor = 56;  // int? | 

            try
            {
                Transfers result = apiInstance.FundsPending(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.FundsPending: " + e.Message );
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

            var apiInstance = new FundsApi();
            var investor = 56;  // int? | 
            var request = new ScheduledTransfer(); // ScheduledTransfer | 

            try
            {
                ScheduledTransfer result = apiInstance.FundsWithdraw(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.FundsWithdraw: " + e.Message );
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


# IO.Swagger.Api.FundsApi

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](FundsApi.md#add) | **POST** /accounts/{investor}/funds/add | 
[**Cancel**](FundsApi.md#cancel) | **POST** /accounts/{investor}/funds/cancel | 
[**Pending**](FundsApi.md#pending) | **GET** /accounts/{investor}/funds/pending | 
[**Withdraw**](FundsApi.md#withdraw) | **POST** /accounts/{investor}/funds/withdraw | 


<a name="add"></a>
# **Add**
> ScheduledTransfer Add (int? investor, ScheduledTransfer request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddExample
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
                ScheduledTransfer result = apiInstance.Add(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.Add: " + e.Message );
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

<a name="cancel"></a>
# **Cancel**
> CancelTransferResponse Cancel (int? investor, CancelTransferRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelExample
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
                CancelTransferResponse result = apiInstance.Cancel(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.Cancel: " + e.Message );
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

<a name="pending"></a>
# **Pending**
> Transfers Pending (int? investor)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PendingExample
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
                Transfers result = apiInstance.Pending(investor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.Pending: " + e.Message );
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

<a name="withdraw"></a>
# **Withdraw**
> ScheduledTransfer Withdraw (int? investor, ScheduledTransfer request)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawExample
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
                ScheduledTransfer result = apiInstance.Withdraw(investor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundsApi.Withdraw: " + e.Message );
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


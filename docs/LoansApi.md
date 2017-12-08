# IO.Swagger.Api.LoansApi

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListedLoans**](LoansApi.md#listedloans) | **GET** /loans/listing | 


<a name="listedloans"></a>
# **ListedLoans**
> ListedLoans ListedLoans (int? filterId = null, bool? showAll = null, string X_LC_LISTING_VERSION = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListedLoansExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoansApi();
            var filterId = 56;  // int? |  (optional) 
            var showAll = true;  // bool? |  (optional) 
            var X_LC_LISTING_VERSION = X_LC_LISTING_VERSION_example;  // string |  (optional) 

            try
            {
                ListedLoans result = apiInstance.ListedLoans(filterId, showAll, X_LC_LISTING_VERSION);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.ListedLoans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **int?**|  | [optional] 
 **showAll** | **bool?**|  | [optional] 
 **X_LC_LISTING_VERSION** | **string**|  | [optional] 

### Return type

[**ListedLoans**](ListedLoans.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


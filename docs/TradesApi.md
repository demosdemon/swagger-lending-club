# IO.Swagger.Api.TradesApi

All URIs are relative to *https://api.lendingclub.com/api/investor/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuyNotes**](TradesApi.md#buynotes) | **POST** /accounts/{investor}/trades/buy | 
[**SellNotes**](TradesApi.md#sellnotes) | **POST** /accounts/{investor}/trades/sell | 


<a name="buynotes"></a>
# **BuyNotes**
> BuyNotesResponse BuyNotes (int? investor, BuyNotesRequest buyNotes)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BuyNotesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradesApi();
            var investor = 56;  // int? | 
            var buyNotes = new BuyNotesRequest(); // BuyNotesRequest | 

            try
            {
                BuyNotesResponse result = apiInstance.BuyNotes(investor, buyNotes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.BuyNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **buyNotes** | [**BuyNotesRequest**](BuyNotesRequest.md)|  | 

### Return type

[**BuyNotesResponse**](BuyNotesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sellnotes"></a>
# **SellNotes**
> SellNotesResponse SellNotes (int? investor, SellNotesRequest sellNotes)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SellNotesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradesApi();
            var investor = 56;  // int? | 
            var sellNotes = new SellNotesRequest(); // SellNotesRequest | 

            try
            {
                SellNotesResponse result = apiInstance.SellNotes(investor, sellNotes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.SellNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investor** | **int?**|  | 
 **sellNotes** | [**SellNotesRequest**](SellNotesRequest.md)|  | 

### Return type

[**SellNotesResponse**](SellNotesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


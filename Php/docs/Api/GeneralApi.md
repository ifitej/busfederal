# Swagger\Client\GeneralApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiGetAuthorityUrlGet**](GeneralApi.md#apigetauthorityurlget) | **GET** /api/getAuthorityUrl | 

# **apiGetAuthorityUrlGet**
> \Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e apiGetAuthorityUrlGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\GeneralApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiGetAuthorityUrlGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling GeneralApi->apiGetAuthorityUrlGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e**](../Model/BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


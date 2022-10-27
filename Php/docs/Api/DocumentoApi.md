# Swagger\Client\DocumentoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**brokerEnviarDocumentoPost**](DocumentoApi.md#brokerenviardocumentopost) | **POST** /Broker/EnviarDocumento | 
[**documentoBinarioGet**](DocumentoApi.md#documentobinarioget) | **GET** /documento/binario | 
[**documentoDataGet**](DocumentoApi.md#documentodataget) | **GET** /documento/data | 
[**documentoGet**](DocumentoApi.md#documentoget) | **GET** /documento | 
[**documentoLinkGet**](DocumentoApi.md#documentolinkget) | **GET** /documento/link | 
[**enviarPost**](DocumentoApi.md#enviarpost) | **POST** /enviar | 

# **brokerEnviarDocumentoPost**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull brokerEnviarDocumentoPost($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest(); // \Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest | 

try {
    $result = $apiInstance->brokerEnviarDocumentoPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->brokerEnviarDocumentoPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest**](../Model/BFBordeModelsApiModelDocumentoEnviarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **documentoBinarioGet**
> \Swagger\Client\Model\BFCommonServiceResponse1SystemByteSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e documentoBinarioGet($uuid)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 

try {
    $result = $apiInstance->documentoBinarioGet($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->documentoBinarioGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1SystemByteSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e**](../Model/BFCommonServiceResponse1SystemByteSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **documentoDataGet**
> \Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e documentoDataGet($uuid)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 

try {
    $result = $apiInstance->documentoDataGet($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->documentoDataGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e**](../Model/BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **documentoGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull documentoGet($uuid)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 

try {
    $result = $apiInstance->documentoGet($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->documentoGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **documentoLinkGet**
> \Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e documentoLinkGet($uuid)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 

try {
    $result = $apiInstance->documentoLinkGet($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->documentoLinkGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e**](../Model/BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **enviarPost**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull enviarPost($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DocumentoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest(); // \Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest | 

try {
    $result = $apiInstance->enviarPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DocumentoApi->enviarPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsApiModelDocumentoEnviarRequest**](../Model/BFBordeModelsApiModelDocumentoEnviarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


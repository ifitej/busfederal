# Swagger\Client\CausaApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiGetCausaCaratulaGet**](CausaApi.md#apigetcausacaratulaget) | **GET** /api/get_causa_caratula | 
[**apiGetCausaNumeroGet**](CausaApi.md#apigetcausanumeroget) | **GET** /api/get_causa_numero | 

# **apiGetCausaCaratulaGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull apiGetCausaCaratulaGet($caratula_busqueda, $codigo_organismo, $codigo_depenencia)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\CausaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$caratula_busqueda = "caratula_busqueda_example"; // string | 
$codigo_organismo = "codigo_organismo_example"; // string | 
$codigo_depenencia = "codigo_depenencia_example"; // string | 

try {
    $result = $apiInstance->apiGetCausaCaratulaGet($caratula_busqueda, $codigo_organismo, $codigo_depenencia);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CausaApi->apiGetCausaCaratulaGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caratula_busqueda** | **string**|  | [optional]
 **codigo_organismo** | **string**|  | [optional]
 **codigo_depenencia** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiGetCausaNumeroGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull apiGetCausaNumeroGet($numero, $codigo_organismo, $codigo_depenencia)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\CausaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$numero = "numero_example"; // string | 
$codigo_organismo = "codigo_organismo_example"; // string | 
$codigo_depenencia = "codigo_depenencia_example"; // string | 

try {
    $result = $apiInstance->apiGetCausaNumeroGet($numero, $codigo_organismo, $codigo_depenencia);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CausaApi->apiGetCausaNumeroGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numero** | **string**|  | [optional]
 **codigo_organismo** | **string**|  | [optional]
 **codigo_depenencia** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


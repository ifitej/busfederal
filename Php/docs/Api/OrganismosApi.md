# Swagger\Client\OrganismosApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**organismosGet**](OrganismosApi.md#organismosget) | **GET** /organismos | 
[**organismosSincronizarPost**](OrganismosApi.md#organismossincronizarpost) | **POST** /organismos/sincronizar | 

# **organismosGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull organismosGet($codigo_organismo, $nombre, $provincia)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\OrganismosApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codigo_organismo = "codigo_organismo_example"; // string | 
$nombre = "nombre_example"; // string | 
$provincia = "provincia_example"; // string | 

try {
    $result = $apiInstance->organismosGet($codigo_organismo, $nombre, $provincia);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrganismosApi->organismosGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigo_organismo** | **string**|  | [optional]
 **nombre** | **string**|  | [optional]
 **provincia** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **organismosSincronizarPost**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoSincronizarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull organismosSincronizarPost($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\OrganismosApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsServicesOrganismosOrganismoSincronizarRequest(); // \Swagger\Client\Model\BFBordeModelsServicesOrganismosOrganismoSincronizarRequest | 

try {
    $result = $apiInstance->organismosSincronizarPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrganismosApi->organismosSincronizarPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsServicesOrganismosOrganismoSincronizarRequest**](../Model/BFBordeModelsServicesOrganismosOrganismoSincronizarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoSincronizarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoSincronizarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


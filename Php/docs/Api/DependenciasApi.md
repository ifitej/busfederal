# Swagger\Client\DependenciasApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dependenciasDelete**](DependenciasApi.md#dependenciasdelete) | **DELETE** /dependencias | 
[**dependenciasGet**](DependenciasApi.md#dependenciasget) | **GET** /dependencias | 
[**dependenciasPut**](DependenciasApi.md#dependenciasput) | **PUT** /dependencias | 

# **dependenciasDelete**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaEliminarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull dependenciasDelete($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DependenciasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsApiModelDependenciaEliminarRequest(); // \Swagger\Client\Model\BFBordeModelsApiModelDependenciaEliminarRequest | 

try {
    $result = $apiInstance->dependenciasDelete($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DependenciasApi->dependenciasDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsApiModelDependenciaEliminarRequest**](../Model/BFBordeModelsApiModelDependenciaEliminarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaEliminarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaEliminarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **dependenciasGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull dependenciasGet($codigo_organismo, $codigo_dependencia, $nombre_organismo, $nombre, $fuero, $instancia, $ciudad, $numero_pagina, $registros_por_pagina)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DependenciasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codigo_organismo = "codigo_organismo_example"; // string | 
$codigo_dependencia = "codigo_dependencia_example"; // string | 
$nombre_organismo = "nombre_organismo_example"; // string | 
$nombre = "nombre_example"; // string | 
$fuero = "fuero_example"; // string | 
$instancia = "instancia_example"; // string | 
$ciudad = "ciudad_example"; // string | 
$numero_pagina = 56; // int | 
$registros_por_pagina = 56; // int | 

try {
    $result = $apiInstance->dependenciasGet($codigo_organismo, $codigo_dependencia, $nombre_organismo, $nombre, $fuero, $instancia, $ciudad, $numero_pagina, $registros_por_pagina);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DependenciasApi->dependenciasGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigo_organismo** | **string**|  | [optional]
 **codigo_dependencia** | **string**|  | [optional]
 **nombre_organismo** | **string**|  | [optional]
 **nombre** | **string**|  | [optional]
 **fuero** | **string**|  | [optional]
 **instancia** | **string**|  | [optional]
 **ciudad** | **string**|  | [optional]
 **numero_pagina** | **int**|  | [optional]
 **registros_por_pagina** | **int**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **dependenciasPut**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaGuardarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull dependenciasPut($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\DependenciasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsApiModelDependenciaGuardarRequest(); // \Swagger\Client\Model\BFBordeModelsApiModelDependenciaGuardarRequest | 

try {
    $result = $apiInstance->dependenciasPut($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DependenciasApi->dependenciasPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsApiModelDependenciaGuardarRequest**](../Model/BFBordeModelsApiModelDependenciaGuardarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaGuardarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaGuardarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


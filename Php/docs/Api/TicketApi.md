# Swagger\Client\TicketApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ticketBuscarPost**](TicketApi.md#ticketbuscarpost) | **POST** /ticket/buscar | 
[**ticketGet**](TicketApi.md#ticketget) | **GET** /ticket | 
[**ticketNuevosGet**](TicketApi.md#ticketnuevosget) | **GET** /ticket/nuevos | 

# **ticketBuscarPost**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull ticketBuscarPost($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\TicketApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\BFBordeModelsApiModelTicketBuscarRequest(); // \Swagger\Client\Model\BFBordeModelsApiModelTicketBuscarRequest | 

try {
    $result = $apiInstance->ticketBuscarPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TicketApi->ticketBuscarPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BFBordeModelsApiModelTicketBuscarRequest**](../Model/BFBordeModelsApiModelTicketBuscarRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ticketGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull ticketGet($uuid)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\TicketApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 

try {
    $result = $apiInstance->ticketGet($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TicketApi->ticketGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ticketNuevosGet**
> \Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull ticketNuevosGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: Bearer
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\TicketApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->ticketNuevosGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TicketApi->ticketNuevosGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull**](../Model/BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


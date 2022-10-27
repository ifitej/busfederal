# BF.API Cliente-php

Cliente PHP generado con [Swagger Codegen](https://github.com/swagger-api/swagger-codegen).

- API version: v1
- Build package: io.swagger.codegen.v3.generators.php.PhpClientCodegen

## Requirementos

PHP 5.5 o mayor

## Instalación & Uso
### Composer

```
git clone https://github.com/ifitej/busfederal.git

```

Luego ejecutar `composer install`

### Instalación Manual

Descargar e incluir `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/vendor/autoload.php');
```

## Tests

Proximamente

## Getting Started

### Autorización
Debes completar el archivo ubicado en /lib/.env con tus credenciales de acceso o también podes setearlas como variables de entorno.

```
CLIENT_ID=""
SECRET_KEY=""
BASE_URL=""
```

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

use Swagger\Client\Configuration;

//Instancia del objeto Configuration

$config = new Configuration();

//Metodo Authorize para negociar el Token

$config->Authorize();

//Ejemplo de Listado de Organismos

$apiInstance = new Swagger\Client\Api\OrganismosApi(
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->organismosGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrganismosApi->organismosGet: ', $e->getMessage(), PHP_EOL;
}

?>
```

## Documentación para los Endpoints de la API


Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CausaApi* | [**apiGetCausaCaratulaGet**](docs/Api/CausaApi.md#apigetcausacaratulaget) | **GET** /api/get_causa_caratula | 
*CausaApi* | [**apiGetCausaNumeroGet**](docs/Api/CausaApi.md#apigetcausanumeroget) | **GET** /api/get_causa_numero | 
*DependenciasApi* | [**dependenciasDelete**](docs/Api/DependenciasApi.md#dependenciasdelete) | **DELETE** /dependencias | 
*DependenciasApi* | [**dependenciasGet**](docs/Api/DependenciasApi.md#dependenciasget) | **GET** /dependencias | 
*DependenciasApi* | [**dependenciasPut**](docs/Api/DependenciasApi.md#dependenciasput) | **PUT** /dependencias | 
*DocumentoApi* | [**brokerEnviarDocumentoPost**](docs/Api/DocumentoApi.md#brokerenviardocumentopost) | **POST** /Broker/EnviarDocumento | 
*DocumentoApi* | [**documentoBinarioGet**](docs/Api/DocumentoApi.md#documentobinarioget) | **GET** /documento/binario | 
*DocumentoApi* | [**documentoDataGet**](docs/Api/DocumentoApi.md#documentodataget) | **GET** /documento/data | 
*DocumentoApi* | [**documentoGet**](docs/Api/DocumentoApi.md#documentoget) | **GET** /documento | 
*DocumentoApi* | [**documentoLinkGet**](docs/Api/DocumentoApi.md#documentolinkget) | **GET** /documento/link | 
*DocumentoApi* | [**enviarPost**](docs/Api/DocumentoApi.md#enviarpost) | **POST** /enviar | 
*GeneralApi* | [**apiGetAuthorityUrlGet**](docs/Api/GeneralApi.md#apigetauthorityurlget) | **GET** /api/getAuthorityUrl | 
*OrganismosApi* | [**organismosGet**](docs/Api/OrganismosApi.md#organismosget) | **GET** /organismos | 
*OrganismosApi* | [**organismosSincronizarPost**](docs/Api/OrganismosApi.md#organismossincronizarpost) | **POST** /organismos/sincronizar | 
*StatusApi* | [**statusPingGet**](docs/Api/StatusApi.md#statuspingget) | **GET** /status/ping | 
*StatusApi* | [**statusReadyGet**](docs/Api/StatusApi.md#statusreadyget) | **GET** /status/ready | 
*StatusApi* | [**statusVersionGet**](docs/Api/StatusApi.md#statusversionget) | **GET** /status/version | 
*TicketApi* | [**ticketBuscarPost**](docs/Api/TicketApi.md#ticketbuscarpost) | **POST** /ticket/buscar | 
*TicketApi* | [**ticketGet**](docs/Api/TicketApi.md#ticketget) | **GET** /ticket | 
*TicketApi* | [**ticketNuevosGet**](docs/Api/TicketApi.md#ticketnuevosget) | **GET** /ticket/nuevos | 

## Documentation For Models

 - [BFBordeModelsApiModelDependenciaEliminarRequest](docs/Model/BFBordeModelsApiModelDependenciaEliminarRequest.md)
 - [BFBordeModelsApiModelDependenciaGuardarRequest](docs/Model/BFBordeModelsApiModelDependenciaGuardarRequest.md)
 - [BFBordeModelsApiModelDocumentoEnviarRequest](docs/Model/BFBordeModelsApiModelDocumentoEnviarRequest.md)
 - [BFBordeModelsApiModelTicketBuscarRequest](docs/Model/BFBordeModelsApiModelTicketBuscarRequest.md)
 - [BFBordeModelsApiModelTicketCausaItem](docs/Model/BFBordeModelsApiModelTicketCausaItem.md)
 - [BFBordeModelsComandosDependenciasDependenciaDto](docs/Model/BFBordeModelsComandosDependenciasDependenciaDto.md)
 - [BFBordeModelsComandosDependenciasUbicacionDto](docs/Model/BFBordeModelsComandosDependenciasUbicacionDto.md)
 - [BFBordeModelsComandosDependenciasUbicacionDtoGeoRefCentroide](docs/Model/BFBordeModelsComandosDependenciasUbicacionDtoGeoRefCentroide.md)
 - [BFBordeModelsComandosDependenciasUbicacionDtoGeoRefDto](docs/Model/BFBordeModelsComandosDependenciasUbicacionDtoGeoRefDto.md)
 - [BFBordeModelsComandosEscribanoTicketDto](docs/Model/BFBordeModelsComandosEscribanoTicketDto.md)
 - [BFBordeModelsComandosEscribanoTicketDtoBlockChanRegistroItem](docs/Model/BFBordeModelsComandosEscribanoTicketDtoBlockChanRegistroItem.md)
 - [BFBordeModelsComandosEscribanoTicketDtoBlockChanRegistroItemStampItem](docs/Model/BFBordeModelsComandosEscribanoTicketDtoBlockChanRegistroItemStampItem.md)
 - [BFBordeModelsComandosEscribanoTicketDtoTicketDtoItem](docs/Model/BFBordeModelsComandosEscribanoTicketDtoTicketDtoItem.md)
 - [BFBordeModelsComandosEscribanoTicketDtoTransaccionDto](docs/Model/BFBordeModelsComandosEscribanoTicketDtoTransaccionDto.md)
 - [BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto](docs/Model/BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto.md)
 - [BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketIdentificadorDependenciaDto](docs/Model/BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketIdentificadorDependenciaDto.md)
 - [BFBordeModelsComandosOrganismosContactoDto](docs/Model/BFBordeModelsComandosOrganismosContactoDto.md)
 - [BFBordeModelsComandosOrganismosOrganismoDto](docs/Model/BFBordeModelsComandosOrganismosOrganismoDto.md)
 - [BFBordeModelsComandosOrganismosPoliticaDto](docs/Model/BFBordeModelsComandosOrganismosPoliticaDto.md)
 - [BFBordeModelsServicesCausasBuscarCausaResponse](docs/Model/BFBordeModelsServicesCausasBuscarCausaResponse.md)
 - [BFBordeModelsServicesCausasBuscarCausaResponseItem](docs/Model/BFBordeModelsServicesCausasBuscarCausaResponseItem.md)
 - [BFBordeModelsServicesDependenciasDependenciaBuscarResponse](docs/Model/BFBordeModelsServicesDependenciasDependenciaBuscarResponse.md)
 - [BFBordeModelsServicesDependenciasDependenciaEliminarResponse](docs/Model/BFBordeModelsServicesDependenciasDependenciaEliminarResponse.md)
 - [BFBordeModelsServicesDependenciasDependenciaGuardarResponse](docs/Model/BFBordeModelsServicesDependenciasDependenciaGuardarResponse.md)
 - [BFBordeModelsServicesDocumentosDocumentoEnviarResponse](docs/Model/BFBordeModelsServicesDocumentosDocumentoEnviarResponse.md)
 - [BFBordeModelsServicesDocumentosDocumentoTraerResponse](docs/Model/BFBordeModelsServicesDocumentosDocumentoTraerResponse.md)
 - [BFBordeModelsServicesOrganismosOrganismoBuscarResponse](docs/Model/BFBordeModelsServicesOrganismosOrganismoBuscarResponse.md)
 - [BFBordeModelsServicesOrganismosOrganismoSincronizarRequest](docs/Model/BFBordeModelsServicesOrganismosOrganismoSincronizarRequest.md)
 - [BFBordeModelsServicesOrganismosOrganismoSincronizarResponse](docs/Model/BFBordeModelsServicesOrganismosOrganismoSincronizarResponse.md)
 - [BFBordeModelsServicesTicketsTicketBuscarResponse](docs/Model/BFBordeModelsServicesTicketsTicketBuscarResponse.md)
 - [BFBordeModelsServicesTicketsTicketTraerResponse](docs/Model/BFBordeModelsServicesTicketsTicketTraerResponse.md)
 - [BFBordeModelsSharedDtosCausaDto](docs/Model/BFBordeModelsSharedDtosCausaDto.md)
 - [BFBordeModelsSharedDtosCausaOrigenDto](docs/Model/BFBordeModelsSharedDtosCausaOrigenDto.md)
 - [BFBordeModelsSharedDtosDocumentoDto](docs/Model/BFBordeModelsSharedDtosDocumentoDto.md)
 - [BFBordeModelsSharedDtosDocumentoSHA256Dto](docs/Model/BFBordeModelsSharedDtosDocumentoSHA256Dto.md)
 - [BFBordeModelsSharedDtosIdentificadorDependenciaDto](docs/Model/BFBordeModelsSharedDtosIdentificadorDependenciaDto.md)
 - [BFBordeModelsSharedDtosMetadataDto](docs/Model/BFBordeModelsSharedDtosMetadataDto.md)
 - [BFCommonDetailError](docs/Model/BFCommonDetailError.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesCausasBuscarCausaResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaEliminarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaEliminarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaGuardarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesDependenciasDependenciaGuardarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoEnviarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesDocumentosDocumentoTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoSincronizarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesOrganismosOrganismoSincronizarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketBuscarResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull](docs/Model/BFCommonServiceResponse1BFBordeModelsServicesTicketsTicketTraerResponseBFBordeModelsVersion11213CultureNeutralPublicKeyTokenNull.md)
 - [BFCommonServiceResponse1SystemByteSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e](docs/Model/BFCommonServiceResponse1SystemByteSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)
 - [BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e](docs/Model/BFCommonServiceResponse1SystemStringSystemPrivateCoreLibVersion6000CultureNeutralPublicKeyToken7cec85d7bea7798e.md)

## Bearer

- **Type**: HTTP bearer authentication


## Author
Bus Federal de Justicia



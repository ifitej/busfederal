<?php

require_once('vendor/autoload.php');

use Swagger\Client\Configuration;

$config = new Configuration();

$config->Authorize();


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

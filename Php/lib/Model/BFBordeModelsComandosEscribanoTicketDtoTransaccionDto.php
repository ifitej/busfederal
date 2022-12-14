<?php
/**
 * BFBordeModelsComandosEscribanoTicketDtoTransaccionDto
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BF.Borde.Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.35
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * BFBordeModelsComandosEscribanoTicketDtoTransaccionDto Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class BFBordeModelsComandosEscribanoTicketDtoTransaccionDto implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'BF.Borde.Models.Comandos.Escribano.TicketDto+TransaccionDto';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'id' => 'string',
'tipo' => 'string',
'timestamp' => '\DateTime',
'topic' => 'string',
'origen' => '\Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto',
'destino' => '\Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto',
'documento' => '\Swagger\Client\Model\BFBordeModelsSharedDtosDocumentoSHA256Dto',
'data' => '\Swagger\Client\Model\BFBordeModelsSharedDtosMetadataDto'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'id' => null,
'tipo' => null,
'timestamp' => 'date-time',
'topic' => null,
'origen' => null,
'destino' => null,
'documento' => null,
'data' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'id',
'tipo' => 'tipo',
'timestamp' => 'timestamp',
'topic' => 'topic',
'origen' => 'origen',
'destino' => 'destino',
'documento' => 'documento',
'data' => 'data'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
'tipo' => 'setTipo',
'timestamp' => 'setTimestamp',
'topic' => 'setTopic',
'origen' => 'setOrigen',
'destino' => 'setDestino',
'documento' => 'setDocumento',
'data' => 'setData'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
'tipo' => 'getTipo',
'timestamp' => 'getTimestamp',
'topic' => 'getTopic',
'origen' => 'getOrigen',
'destino' => 'getDestino',
'documento' => 'getDocumento',
'data' => 'getData'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['id'] = isset($data['id']) ? $data['id'] : null;
        $this->container['tipo'] = isset($data['tipo']) ? $data['tipo'] : null;
        $this->container['timestamp'] = isset($data['timestamp']) ? $data['timestamp'] : null;
        $this->container['topic'] = isset($data['topic']) ? $data['topic'] : null;
        $this->container['origen'] = isset($data['origen']) ? $data['origen'] : null;
        $this->container['destino'] = isset($data['destino']) ? $data['destino'] : null;
        $this->container['documento'] = isset($data['documento']) ? $data['documento'] : null;
        $this->container['data'] = isset($data['data']) ? $data['data'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets id
     *
     * @return string
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param string $id id
     *
     * @return $this
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets tipo
     *
     * @return string
     */
    public function getTipo()
    {
        return $this->container['tipo'];
    }

    /**
     * Sets tipo
     *
     * @param string $tipo tipo
     *
     * @return $this
     */
    public function setTipo($tipo)
    {
        $this->container['tipo'] = $tipo;

        return $this;
    }

    /**
     * Gets timestamp
     *
     * @return \DateTime
     */
    public function getTimestamp()
    {
        return $this->container['timestamp'];
    }

    /**
     * Sets timestamp
     *
     * @param \DateTime $timestamp timestamp
     *
     * @return $this
     */
    public function setTimestamp($timestamp)
    {
        $this->container['timestamp'] = $timestamp;

        return $this;
    }

    /**
     * Gets topic
     *
     * @return string
     */
    public function getTopic()
    {
        return $this->container['topic'];
    }

    /**
     * Sets topic
     *
     * @param string $topic topic
     *
     * @return $this
     */
    public function setTopic($topic)
    {
        $this->container['topic'] = $topic;

        return $this;
    }

    /**
     * Gets origen
     *
     * @return \Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto
     */
    public function getOrigen()
    {
        return $this->container['origen'];
    }

    /**
     * Sets origen
     *
     * @param \Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto $origen origen
     *
     * @return $this
     */
    public function setOrigen($origen)
    {
        $this->container['origen'] = $origen;

        return $this;
    }

    /**
     * Gets destino
     *
     * @return \Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto
     */
    public function getDestino()
    {
        return $this->container['destino'];
    }

    /**
     * Sets destino
     *
     * @param \Swagger\Client\Model\BFBordeModelsComandosEscribanoTicketDtoTransaccionDtoTicketCausaDto $destino destino
     *
     * @return $this
     */
    public function setDestino($destino)
    {
        $this->container['destino'] = $destino;

        return $this;
    }

    /**
     * Gets documento
     *
     * @return \Swagger\Client\Model\BFBordeModelsSharedDtosDocumentoSHA256Dto
     */
    public function getDocumento()
    {
        return $this->container['documento'];
    }

    /**
     * Sets documento
     *
     * @param \Swagger\Client\Model\BFBordeModelsSharedDtosDocumentoSHA256Dto $documento documento
     *
     * @return $this
     */
    public function setDocumento($documento)
    {
        $this->container['documento'] = $documento;

        return $this;
    }

    /**
     * Gets data
     *
     * @return \Swagger\Client\Model\BFBordeModelsSharedDtosMetadataDto
     */
    public function getData()
    {
        return $this->container['data'];
    }

    /**
     * Sets data
     *
     * @param \Swagger\Client\Model\BFBordeModelsSharedDtosMetadataDto $data data
     *
     * @return $this
     */
    public function setData($data)
    {
        $this->container['data'] = $data;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}

<?php
/**
 * BFBordeModelsComandosOrganismosContactoDto
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
 * BFBordeModelsComandosOrganismosContactoDto Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class BFBordeModelsComandosOrganismosContactoDto implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'BF.Borde.Models.Comandos.Organismos.ContactoDto';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'correo_electronico' => 'string',
'nombre_completo' => 'string',
'telefono' => 'string',
'telefono_urgencia' => 'string',
'telefono_guardia' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'correo_electronico' => null,
'nombre_completo' => null,
'telefono' => null,
'telefono_urgencia' => null,
'telefono_guardia' => null    ];

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
        'correo_electronico' => 'correo_electronico',
'nombre_completo' => 'nombre_completo',
'telefono' => 'telefono',
'telefono_urgencia' => 'telefono_urgencia',
'telefono_guardia' => 'telefono_guardia'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'correo_electronico' => 'setCorreoElectronico',
'nombre_completo' => 'setNombreCompleto',
'telefono' => 'setTelefono',
'telefono_urgencia' => 'setTelefonoUrgencia',
'telefono_guardia' => 'setTelefonoGuardia'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'correo_electronico' => 'getCorreoElectronico',
'nombre_completo' => 'getNombreCompleto',
'telefono' => 'getTelefono',
'telefono_urgencia' => 'getTelefonoUrgencia',
'telefono_guardia' => 'getTelefonoGuardia'    ];

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
        $this->container['correo_electronico'] = isset($data['correo_electronico']) ? $data['correo_electronico'] : null;
        $this->container['nombre_completo'] = isset($data['nombre_completo']) ? $data['nombre_completo'] : null;
        $this->container['telefono'] = isset($data['telefono']) ? $data['telefono'] : null;
        $this->container['telefono_urgencia'] = isset($data['telefono_urgencia']) ? $data['telefono_urgencia'] : null;
        $this->container['telefono_guardia'] = isset($data['telefono_guardia']) ? $data['telefono_guardia'] : null;
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
     * Gets correo_electronico
     *
     * @return string
     */
    public function getCorreoElectronico()
    {
        return $this->container['correo_electronico'];
    }

    /**
     * Sets correo_electronico
     *
     * @param string $correo_electronico correo_electronico
     *
     * @return $this
     */
    public function setCorreoElectronico($correo_electronico)
    {
        $this->container['correo_electronico'] = $correo_electronico;

        return $this;
    }

    /**
     * Gets nombre_completo
     *
     * @return string
     */
    public function getNombreCompleto()
    {
        return $this->container['nombre_completo'];
    }

    /**
     * Sets nombre_completo
     *
     * @param string $nombre_completo nombre_completo
     *
     * @return $this
     */
    public function setNombreCompleto($nombre_completo)
    {
        $this->container['nombre_completo'] = $nombre_completo;

        return $this;
    }

    /**
     * Gets telefono
     *
     * @return string
     */
    public function getTelefono()
    {
        return $this->container['telefono'];
    }

    /**
     * Sets telefono
     *
     * @param string $telefono telefono
     *
     * @return $this
     */
    public function setTelefono($telefono)
    {
        $this->container['telefono'] = $telefono;

        return $this;
    }

    /**
     * Gets telefono_urgencia
     *
     * @return string
     */
    public function getTelefonoUrgencia()
    {
        return $this->container['telefono_urgencia'];
    }

    /**
     * Sets telefono_urgencia
     *
     * @param string $telefono_urgencia telefono_urgencia
     *
     * @return $this
     */
    public function setTelefonoUrgencia($telefono_urgencia)
    {
        $this->container['telefono_urgencia'] = $telefono_urgencia;

        return $this;
    }

    /**
     * Gets telefono_guardia
     *
     * @return string
     */
    public function getTelefonoGuardia()
    {
        return $this->container['telefono_guardia'];
    }

    /**
     * Sets telefono_guardia
     *
     * @param string $telefono_guardia telefono_guardia
     *
     * @return $this
     */
    public function setTelefonoGuardia($telefono_guardia)
    {
        $this->container['telefono_guardia'] = $telefono_guardia;

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
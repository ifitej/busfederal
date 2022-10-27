<?php
/**
 * BFBordeModelsApiModelDependenciaGuardarRequest
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
 * BFBordeModelsApiModelDependenciaGuardarRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class BFBordeModelsApiModelDependenciaGuardarRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'BF.Borde.Models.ApiModel.DependenciaGuardarRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'id_interno' => 'string',
'codigo_dependencia' => 'string',
'nombre' => 'string',
'descripcion' => 'string',
'fuero' => 'string',
'instancia' => 'string',
'ubicacion' => '\Swagger\Client\Model\BFBordeModelsComandosDependenciasUbicacionDto',
'datos_contacto' => '\Swagger\Client\Model\BFBordeModelsComandosOrganismosContactoDto'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'id_interno' => null,
'codigo_dependencia' => null,
'nombre' => null,
'descripcion' => null,
'fuero' => null,
'instancia' => null,
'ubicacion' => null,
'datos_contacto' => null    ];

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
        'id_interno' => 'id_interno',
'codigo_dependencia' => 'codigo_dependencia',
'nombre' => 'nombre',
'descripcion' => 'descripcion',
'fuero' => 'fuero',
'instancia' => 'instancia',
'ubicacion' => 'ubicacion',
'datos_contacto' => 'datos_contacto'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id_interno' => 'setIdInterno',
'codigo_dependencia' => 'setCodigoDependencia',
'nombre' => 'setNombre',
'descripcion' => 'setDescripcion',
'fuero' => 'setFuero',
'instancia' => 'setInstancia',
'ubicacion' => 'setUbicacion',
'datos_contacto' => 'setDatosContacto'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id_interno' => 'getIdInterno',
'codigo_dependencia' => 'getCodigoDependencia',
'nombre' => 'getNombre',
'descripcion' => 'getDescripcion',
'fuero' => 'getFuero',
'instancia' => 'getInstancia',
'ubicacion' => 'getUbicacion',
'datos_contacto' => 'getDatosContacto'    ];

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
        $this->container['id_interno'] = isset($data['id_interno']) ? $data['id_interno'] : null;
        $this->container['codigo_dependencia'] = isset($data['codigo_dependencia']) ? $data['codigo_dependencia'] : null;
        $this->container['nombre'] = isset($data['nombre']) ? $data['nombre'] : null;
        $this->container['descripcion'] = isset($data['descripcion']) ? $data['descripcion'] : null;
        $this->container['fuero'] = isset($data['fuero']) ? $data['fuero'] : null;
        $this->container['instancia'] = isset($data['instancia']) ? $data['instancia'] : null;
        $this->container['ubicacion'] = isset($data['ubicacion']) ? $data['ubicacion'] : null;
        $this->container['datos_contacto'] = isset($data['datos_contacto']) ? $data['datos_contacto'] : null;
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
     * Gets id_interno
     *
     * @return string
     */
    public function getIdInterno()
    {
        return $this->container['id_interno'];
    }

    /**
     * Sets id_interno
     *
     * @param string $id_interno id_interno
     *
     * @return $this
     */
    public function setIdInterno($id_interno)
    {
        $this->container['id_interno'] = $id_interno;

        return $this;
    }

    /**
     * Gets codigo_dependencia
     *
     * @return string
     */
    public function getCodigoDependencia()
    {
        return $this->container['codigo_dependencia'];
    }

    /**
     * Sets codigo_dependencia
     *
     * @param string $codigo_dependencia codigo_dependencia
     *
     * @return $this
     */
    public function setCodigoDependencia($codigo_dependencia)
    {
        $this->container['codigo_dependencia'] = $codigo_dependencia;

        return $this;
    }

    /**
     * Gets nombre
     *
     * @return string
     */
    public function getNombre()
    {
        return $this->container['nombre'];
    }

    /**
     * Sets nombre
     *
     * @param string $nombre nombre
     *
     * @return $this
     */
    public function setNombre($nombre)
    {
        $this->container['nombre'] = $nombre;

        return $this;
    }

    /**
     * Gets descripcion
     *
     * @return string
     */
    public function getDescripcion()
    {
        return $this->container['descripcion'];
    }

    /**
     * Sets descripcion
     *
     * @param string $descripcion descripcion
     *
     * @return $this
     */
    public function setDescripcion($descripcion)
    {
        $this->container['descripcion'] = $descripcion;

        return $this;
    }

    /**
     * Gets fuero
     *
     * @return string
     */
    public function getFuero()
    {
        return $this->container['fuero'];
    }

    /**
     * Sets fuero
     *
     * @param string $fuero fuero
     *
     * @return $this
     */
    public function setFuero($fuero)
    {
        $this->container['fuero'] = $fuero;

        return $this;
    }

    /**
     * Gets instancia
     *
     * @return string
     */
    public function getInstancia()
    {
        return $this->container['instancia'];
    }

    /**
     * Sets instancia
     *
     * @param string $instancia instancia
     *
     * @return $this
     */
    public function setInstancia($instancia)
    {
        $this->container['instancia'] = $instancia;

        return $this;
    }

    /**
     * Gets ubicacion
     *
     * @return \Swagger\Client\Model\BFBordeModelsComandosDependenciasUbicacionDto
     */
    public function getUbicacion()
    {
        return $this->container['ubicacion'];
    }

    /**
     * Sets ubicacion
     *
     * @param \Swagger\Client\Model\BFBordeModelsComandosDependenciasUbicacionDto $ubicacion ubicacion
     *
     * @return $this
     */
    public function setUbicacion($ubicacion)
    {
        $this->container['ubicacion'] = $ubicacion;

        return $this;
    }

    /**
     * Gets datos_contacto
     *
     * @return \Swagger\Client\Model\BFBordeModelsComandosOrganismosContactoDto
     */
    public function getDatosContacto()
    {
        return $this->container['datos_contacto'];
    }

    /**
     * Sets datos_contacto
     *
     * @param \Swagger\Client\Model\BFBordeModelsComandosOrganismosContactoDto $datos_contacto datos_contacto
     *
     * @return $this
     */
    public function setDatosContacto($datos_contacto)
    {
        $this->container['datos_contacto'] = $datos_contacto;

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
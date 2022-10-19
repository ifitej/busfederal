## Dependencia maven (lastest)
```xml
    <dependency>
        <groupId>ar.gov.jussanjuan</groupId>
        <artifactId>sdkbus</artifactId>
        <version>0.1.5-SNAPSHOT</version>
    </dependency>
```
## Importar en tu proyecto
La dependencia maven debe importarse en el archivo pom.xml de tu proyecto. Esta se descargará del repositorio de jussanjuan.

## Variables necesarias y obligatorias

Las credenciales para autenticarse contra la Api de Borde del Bus se deberán setear en el archivo application.properties o application.yml de tu proyecto Spring que implementará el SDK del Bus. El formato es el siguiente: 

(application.properties)

**bus-federal.clientid=XXXXXX**

**bus-federal.clientsecret=XXXXXX**

(application.yml)
```yml
bus-federal:
  client-id: XXXXXX
  client-secret: XXXXXX
```

> El **clientid** y **clientsecret** se deben solicitar a Gustavo Perez Villar.

## Usando el SDK
El servicio principal se llama SDKBus. Dentro de ese servicio están todos los métodos para comunicarse con la API del Bus.
Dicho servicio debe inyectarse donde se necesite, por ejemplo de la siguiente manera:

```java
@RestController
@RequestMapping("/bus")
public class BusController
{
    @Autowired
    private SDKBus sdkBus;

    @GetMapping("/dependencias")
    ResponseEntity<BusResponse<DataResponse<Dependencia>>> getDependencias(@RequestParam Map<String, String> allRequestParams){
        return ResponseEntity.ok(this.sdkBus.findDependencias(allRequestParams));
    }
}
```

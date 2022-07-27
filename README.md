# BUS Federal de Justicia
## Librerias de integracion BUS Federal de Justicia

### ¿Que es Bus Federal de Justicia?

Es una plataforma estándar digital entre los organismos judiciales, entidades públicas y privadas que permita interoperar en todos los trámites. Permite integrar aplicaciones y procesos para organismos públicos y privados en su gestión digital con los poderes judiciales del país.

Generado por la Junta Federal de Poderes Judiciales desde el IFITEJ (Instituto Federa de Innovación Tecnología y Justicia), Suprema Corte de Buenos Aires con aportes del Ministerio de Justicia de Nación. 

### Premisas del proyecto

- Definir un proceso estándar digital para las provincias JUFEJUS que permita la interoperabilidad digital de procesos.
- Garantizar la neutralidad tecnológica que permita la independencia de herramientas y políticas de informatización que cada organismo determine.
- Permitir un ingreso por etapas al proyecto de cada poder judicial. 
- Cada proceso integrado deberá brindar posibilidades de uso con un API para integración desde los sistemas de gestión o un front-end que permita su empleo sin integración. 
- Brindar solución interoperable con CSJN, Poder Judicial de Buenos Aires y otros organismos Nacionales, Provinciales y Municipales que resulten parte directa o indirecta del proceso Judicial.
- Mantener registro abierto, detallado y trazable de todas las transacciones que se lleven a cabo dentro del BUS Judicial, permitiendo todas las operaciones realizadas en el sistema.
- Generar en cada servicio un esquema de soporte adecuado para la gestión permanente del proceso.
- La arquitectura del proyecto permitirá un intercambio digital en forma segura, trazable y auditable de documental en formato digital. Esta plataforma denominada BUS-JUSTICIA permitirá establecer un canal digital seguro entre los organismos participantes. Sobre el BUS-JUSTICIA en diferentes etapas se podrán establecer servicios de intercambio de documentos, expedientes digitales, consumo de servicios de consulta y otros que se diseñen a futuro. 
- Dicho BUS-JUSTICIA será diseñado por etapas paulatinas de servicios incluidos en la plataforma. Esto permitirá un crecimiento e integración de los organismos participantes del mismo afianzando el uso operativo de los servicios y su mantenimiento. 

### Quienes pueden integrar?

El BUS Federal de Justicia fue concebido para integracion e intercambio de documentos electronicos en el marco de los procesos Judiciales, interjurisdiccionales y tambien de alcance local o regional. Pueden integrar:

- Poderes Judiciales y Superiores Tribunales de Justicia de la Republica Argentina.
- Organismos publicos Nacionales, Provinciales o Municipales. 
- Colegios Profesionales o entidades no gubernamentales que participen directa o indirectamente del proceso judicial.
- Empresas privadas que participen directa o indirectamente del proceso judicial.

### Que requisitos debo cumplir ?

- Si representas a un Poder Judicial miembro de la Junta Federal de Cortes y Superiores Tribunales de Justicia que adhirio al convenio de Oficios Ley Interjurisdiccionales podes integrar directamente. Solamente tenes que enviar un mail a xxxxx@xxxx.com solicitando las credenciales de acceso a la API de Integracion.
- Si perteneces a un organismo publico o entidad no gubernamental (Colegio Profesional) por favor completa este formulario en linea asi coordinamos una reunion y definimos los alcances de la integracion y te aprovisionamos las credenciales para acceder a la API de integración.
- Si perteneces a una empresa Privada por favor completa este formulario en linea asi coordinamos una reunion y definimos los alcances de la integracion y te aprovisionamos las credenciales para acceder a la API de integración.

### Que hay en este repositorio ?

En este repositorio vas a poder descargar las librerias de integracion con el BUS Federal de Justicia y codigo de ejemplo sobre como integrarlas a tu sistema de gestion. Actualmente solo tenemos librerias de integracion para C# pero proximamente tendremos disponibles librerias para JAVA, PHP, Python y NodeJS. Hasta tanto tengamos disponibles todas las librerias y si no utilizas C#, podes integrar accediendo directamente a la API REST del BUS.

Para eso tenemos disponible un ambiente de SandBox pensado y desplegado para que todos los interesados puedan desarrollar y probar sus integraciones.

### Como accedo al sandbox del BUS Federal ?

Una vez que hayas gestionado las credenciales de acceso podes conectarte a la API de integracion en esta URL:  https://api-borde-qa.bus-justicia.org.ar y tambien podes importar las deficiones de OpenAPI desde esta URL https://api-borde-qa.bus-justicia.org.ar/swagger/v1/swagger.json

Desde la API de integracion vas a poder acceder a los metodos para la gestion de dependencias de tu organizacion (Altas, Bajas y Modificaciones), envio y recepcion de documentos electronicos y descarga del comprobante de la transaccion realizada.

El organismo principal lo definimos desde el backend del BUS como parte del aprovisionamiento de credenciales.

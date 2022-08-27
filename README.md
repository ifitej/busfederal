![enter image description here](https://www.bus-justicia.org.ar/images/iconos/logo-busjus.svg#joomlaImage://local-images/iconos/logo-busjus.svg?width=0&height=0)
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

- Si representas a un Poder Judicial miembro de la Junta Federal de Cortes y Superiores Tribunales de Justicia que adhirio al convenio de Oficios Ley Interjurisdiccionales podes integrar directamente. Solamente tenes que enviar un mail a justiciabus@gmail.com solicitando las credenciales de acceso a la API de Integracion.
- Si perteneces a un organismo publico o entidad no gubernamental (Colegio Profesional) por favor completa este formulario en linea asi coordinamos una reunion y definimos los alcances de la integracion y te aprovisionamos las credenciales para acceder a la API de integración.
- Si perteneces a una empresa Privada por favor completa este formulario en linea asi coordinamos una reunion y definimos los alcances de la integracion y te aprovisionamos las credenciales para acceder a la API de integración.

### Que hay en este repositorio ?

En este repositorio vas a poder descargar las librerias de integracion con el BUS Federal de Justicia y codigo de ejemplo sobre como integrarlas a tu sistema de gestion. Actualmente solo tenemos librerias de integracion para C# pero proximamente tendremos disponibles librerias para JAVA, PHP, Python y NodeJS. Hasta tanto tengamos disponibles todas las librerias y si no utilizas C#, podes integrar accediendo directamente a la API REST del BUS.

Para eso tenemos disponible un ambiente de SandBox pensado y desplegado para que todos los interesados puedan desarrollar y probar sus integraciones.

### Como accedo al sandbox del BUS Federal ?

Una vez que hayas gestionado las credenciales de acceso podes conectarte a la API de integracion en esta URL:  https://api-borde-qa.bus-justicia.org.ar y tambien podes importar las deficiones de OpenAPI desde esta URL https://api-borde-qa.bus-justicia.org.ar/swagger/v1/swagger.json

Desde la API de integracion vas a poder acceder a los metodos para la gestion de dependencias de tu organizacion (Altas, Bajas y Modificaciones), envio y recepcion de documentos electronicos y descarga del comprobante de la transaccion realizada.

El organismo principal lo definimos desde el backend del BUS como parte del aprovisionamiento de credenciales.

# Algunos tips para integrar con el BUS Federal de Justicia

Toda la interacción de tu sistema de gestion con el BUS Federal de Justicia se va a instrumentar con la interface API REST autenticada, esta interface es sincrónica por definición, pero tenes  que tener en cuenta que la operación interna del BUS es completamente asincrónica y el proceso de envió de un documento electrónico a otro organismo a través del BUS se va a dar en dos pasos, y hasta que no esté completo el segundo paso no vas a saber si la operación fue exitosa o no, de hecho puede ser que la transacción demore hasta horas en finalizar ya que utilizamos dependencias externas al BUS que pueden adicionar demoras importantes al proceso.

## Para enviar un documento

El primer paso consiste en enviarle el documento al BUS para eso vas a invocar el método REST /enviar pasando en el cuerpo del mensaje la estructura de datos que podes obtener de la definición OpenAPI de nuestro servicio. Una vez que envíes correctamente el documento, el método enviar te va a devolver un código de operación denominado uuid esto identificador único te va a permitir identificar esta transacción unívocamente. Hasta este punto, la transacción puede ser rechazada por lo que no la tenes que dar por concluida, sino que recomendamos persistir la transacción en un estado PENDIENTE o similar. 
Una vez que la transacción hay sido finalizada, ya sea realizando el envío del documento o rechazándolo el BUS va a emitir un TICKET de comprobante de la transacción. Este ticket no es mas que un documento electrónico estructurado en formato JSON que contiene el detalle de los pasos intermedios realizados por el BUS, los hashes de los documentos y estructuras de datos del mensaje enviado y los datos de sellado de la transacción en el Blockchain Federal Argentina, esto ultimo para que en el futuro puedas utilizar los datos del ticket pa ra acreditar que la operación realmente sucedió.
Para poder finalizar y cerrar la operación de envío, tenes que descargar del BUS un ticket cuyo valor en el campo uuidOperacion coincida con el código uuid que te devolvimos en el paso anterior. Para acceder a los tickets tenes que invocar el método /ticket y pasarle como parámetro el código uuid. Una vez que tengas el ticket, vas a saber si fue exitoso o no y en este ultimo caso vas a tener acceso al motivo del RECHAZO, de una forma u otro ya tenes lo necesario para marcar la transacción como finalizada. En caso de que por algún motivo nunca recibas el ticket, vas a poder usar el código uuid para hacer el reclamo y que nosotros podamos rastrear la transacción.

## Para recibir un documento

Otra implementación a realizar como parte de la integración es la de recepción de documentos electrónicos por parte de otros organismos integrados con el BUS, como explicamos antes, la única forma que tenes de darte cuenta si te llego un documento es a través de los tickets. Para eso podés generar un loop con un delay (en la próxima versión vamos a incluir un aviso tipo PUSH) que busque nuevos tickets emitidos para tu organismo, para esto podes llamar el método /ticket/nuevos de la interface REST, este método te va a devolver todos los tickets con la propiedad leído en false. 
Iterando sobre la colección de tickets que te devuelve el método podés extraer el identificador uuid y usarlo para obtener el documento.

La interface REST tiene varias opciones para obtener el documento y los datos asociados (en caso que los tenga):
-	BASE64: Invocando el método /documento vas a obtener como resultado el contenido del documento en formato BASE64.
-	Binario: Invocando el método /documento/binario vas a obtener el documento en este formato.
-	Link de descarga: Invocando el método /documento/link vas a obtener un enlace de un solo uso que te va a permitir descargar el documento de nuestro repositorio de documentos electrónicos.

Cuando descargues el documento u obtengas el enlace, vamos a marcar el ticket como leído, a si ya no se va a informar en las próximas llamadas. Igualmente, en la interface REST hay métodos que te van a permitir recuperar tickets en función de varios campos de filtro. 
Vale aclarar que el objeto del BUS Federal no es almacenar los documentos, simplemente es asegurar que el documento se entregue, que cumpla con un conjunto mínimo de políticas y que quede un registro trazable de la transacción, es por eso que una vez que descargues el documento u obtengas el link, el BUS va a iniciar un garbage collector y eliminara el documento del repositorio unos días después de descargado.
Por último, y para que sea más simple la realización de pruebas durante la implementación de la integración, tenemos un BOT que responde y envía documentos electrónicos por demanda. De esta forma no dependes de nada para generarte documentos o para responder los que envías.
Para usar el BOT podés hacerlo de dos formas, una es enviando un documento electrónico al código de organismo PDIBFJ-AR-B-PUB y al código de dependencia echo-1, en un lapso no mayor a 30 segundos deberás recibir un ticket de documento electrónico enviado como respuesta al que vos enviaste, en este caso el campo uuid_respuesta del ticket va a coincidir con el código uuid del documento que enviaste originalmente.
El BOT de documentos también tiene un endpoint REST autenticado que te permite disparar el envío de un documento que no esté relacionado con ninguna transacción previa, para esto podes invocar el método /api/enviar_documento?organismo=[tu_codigo_organismo]&dependencia=[codigo_dependencia] en este caso vas a recibir el ticket de documento enviado inmediatamente.
La URL del BOT en el ambiente de sandbox para la integración es https://documentbot-qa.bus-justicia.org.ar

Muchas Gracias.
El equipo del BUS Federal de Justica


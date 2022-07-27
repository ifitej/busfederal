# BUS Federal de Justicia para Intercambio de Documentos Electrónicos

El servicio de borde es el encargado de gestionar la interface entre el sistema externo del organismo y los servicios del BUS-JUSTICIA. Para instrumentar esto el servicio de escribano asumirá un patrón de API Gateway con lógica propia y se complementará con servicios del API Manager de la infraestructura del BUS_JUSTICIA para gestionar la autenticación de los métodos sincrónicos, debiendo tomar datos de la plataforma de autenticación para enriquecer los HEADER de todos los pedidos sincrónicos y asincrónicos subsecuentes vinculando la clave de autenticación utilizada con el ID del organismo propietario.

El servicio de borde ofrecerá mecanismos API REST sincrónicos hacia el organismo externo y colas de comandos y eventos asincrónicos hacia el BUS-JUSTICIA, exceptuando las interacciones para operaciones CRUD de Organismos, las cuales serán sincrónicas hacia el BUS-JUSTICIA mediante API REST y deberán ser instrumentadas a través de la interface de gestion de backend del BUS.

A los efectos de brindar información sobre Organismos y Dependencias a los organismos Externos, el servicio de borde actuara de cache local de Organismos y Dependencias utilizando el canal de Eventos del servicio de organismos para llevar su propia base de datos de organismos y dependencias.
  
## Modo de Uso

    var client = new BordeClient(new BordeClientSettings
    {
        ClientID = "....", 
        SecretClient = "....", 
        ServiceUrl = "......"
    });

    var rs = client.Dependencia.Guardar(new Borde.Models.ApiModel.DependenciaGuardarRequest
    {
        CodigoDependencia = "DEP_1", 
        Nombre = "Dependencia de prueba"
    });

    Console.WriteLine(rs.Status);

    if (rs.Status)
        Console.WriteLine(rs.Data.CodigoDependencia);
    else
        Console.WriteLine(rs.Message);



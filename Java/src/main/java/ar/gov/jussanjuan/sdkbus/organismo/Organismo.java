package ar.gov.jussanjuan.sdkbus.organismo;

import ar.gov.jussanjuan.sdkbus.dto.Policies;
import ar.gov.jussanjuan.sdkbus.dto.DatosContacto;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Organismo {
    private String codigo_organismo;
    private String tipo;
    private String nombre;
    private String descripcion;
    private String callback_service_url;
    private String callback_auth_key;
    private String provincia;
    private String clientId;
    private String normativa_convenio_tipo;
    private String normativa_convenio_numero;
    private String openid_endpoint;
    private List<DatosContacto> datos_contacto;
    private Policies policies;
    private String timestamp_ultima_modificacion;
}

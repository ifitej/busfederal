package ar.gov.jussanjuan.sdkbus.dependencia;

import ar.gov.jussanjuan.sdkbus.dto.Ubicacion;
import ar.gov.jussanjuan.sdkbus.dto.DatosContacto;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Dependencia {
    private String codigo_organismo;
    private String codigo_dependencia;
    private String id_interno;
    private String nombre;
    private String descripcion;
    private String fuero;
    private String instancia;
    private Ubicacion ubicacion;
    private DatosContacto datos_contacto;

}

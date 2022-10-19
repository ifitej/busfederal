package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DatosContacto {
    private String correo_electronico;
    private String nombre_completo;
    private String telefono;
    private String telefono_urgencia;
    private String telefono_guardia;
}

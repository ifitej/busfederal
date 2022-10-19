package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DependenciaTransaccionDTO {
    private String nombre_organismo;
    private String nombre_dependencia;
    private String codigo_organismo;
    private String codigo_dependencia;

}

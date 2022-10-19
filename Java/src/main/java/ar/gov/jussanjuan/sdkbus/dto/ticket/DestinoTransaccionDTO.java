package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DestinoTransaccionDTO {
    private String nro_causa;
    private String caratula;
    private DependenciaTransaccionDTO dependencia;
}

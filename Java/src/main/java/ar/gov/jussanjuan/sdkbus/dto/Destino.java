package ar.gov.jussanjuan.sdkbus.dto;

import ar.gov.jussanjuan.sdkbus.dependencia.Dependencia;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Destino {
    private String nro_causa;
    private String caratula;
    private Dependencia dependencia;
}

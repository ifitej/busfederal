package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Origen {
    private String nro_causa;
    private String caratula;
    private String codigo_dependencia;
}

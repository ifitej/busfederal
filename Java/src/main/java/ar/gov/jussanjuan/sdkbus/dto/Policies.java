package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Policies {
    private String tipo_documento;
    private Boolean firma_obligatoria;
    private Boolean firma_digital;
    private Boolean ts;
}

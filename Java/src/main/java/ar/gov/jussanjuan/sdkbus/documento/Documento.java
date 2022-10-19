package ar.gov.jussanjuan.sdkbus.documento;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Documento {
    private String payload_base64;
    private String nombre_documento;
    private String tipo_documento;
    private String sha_256_payload;
}

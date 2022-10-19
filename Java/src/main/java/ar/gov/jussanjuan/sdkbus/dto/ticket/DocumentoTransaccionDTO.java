package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DocumentoTransaccionDTO {
    private String nombre_documento;
    private String tipo_documento;
    private String sha_256_payload;

}

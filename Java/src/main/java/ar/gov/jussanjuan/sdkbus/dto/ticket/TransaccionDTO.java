package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class TransaccionDTO {
    private String id;
    private String tipo;
    private String timestamp;
    private String topic;
    private OrigenTransaccionDTO origen;
    private DestinoTransaccionDTO destino;
    private DocumentoTransaccionDTO documento;
    private DataTransaccionDTO data;
}

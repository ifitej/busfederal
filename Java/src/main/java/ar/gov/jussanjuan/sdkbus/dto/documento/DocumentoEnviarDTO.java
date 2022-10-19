package ar.gov.jussanjuan.sdkbus.dto.documento;

import ar.gov.jussanjuan.sdkbus.documento.Documento;
import ar.gov.jussanjuan.sdkbus.dto.Destino;
import ar.gov.jussanjuan.sdkbus.dto.Origen;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DocumentoEnviarDTO {
    private DataDTO data;
    private String uuid_respuesta;
    private Origen origen;
    private Destino destino;
    private Documento documento;
}

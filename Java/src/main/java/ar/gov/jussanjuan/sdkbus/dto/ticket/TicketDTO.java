package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class TicketDTO {
    private List<TransaccionDTO> transacciones;
    private String uuid_operacion;
    private String uuid_respuesta;
    private String motivo_estado;
    private String estado;
    private String nro_ticket;
    private String firma_electronica;
    private String timestamp;
}

package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class TicketGralDTO {
    private IdRegBfaDTO id_reg_bfa;
    private String hash_ticket;
    private TicketDTO ticket;
    private String rawData;
    private String leido;
}

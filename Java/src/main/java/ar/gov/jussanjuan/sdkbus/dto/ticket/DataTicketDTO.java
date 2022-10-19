package ar.gov.jussanjuan.sdkbus.dto.ticket;

import ar.gov.jussanjuan.sdkbus.dto.documento.DataDTO;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DataTicketDTO {
    private DataDTO data;
    private TicketGralDTO ticket;
}

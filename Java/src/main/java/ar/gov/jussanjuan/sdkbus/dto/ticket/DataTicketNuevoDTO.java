package ar.gov.jussanjuan.sdkbus.dto.ticket;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DataTicketNuevoDTO {
    private List<TicketGralDTO> tickets;
}

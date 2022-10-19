package ar.gov.jussanjuan.sdkbus.ticket;

import ar.gov.jussanjuan.sdkbus.dto.ticket.DataTicketDTO;
import ar.gov.jussanjuan.sdkbus.dto.ticket.DataTicketNuevoDTO;
import ar.gov.jussanjuan.sdkbus.dto.BusResponse;
import ar.gov.jussanjuan.sdkbus.sdk.SDKBus;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/ticket")
public class TicketController {
    @Autowired
    SDKBus sdkBus;

    @GetMapping("")
    ResponseEntity<BusResponse<DataTicketDTO>>getTicket(@RequestParam("Uuid") String uuid){
        try{
            return ResponseEntity.ok(this.sdkBus.getTicket(uuid));

        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }

    @GetMapping("/nuevos")
    ResponseEntity<BusResponse<DataTicketNuevoDTO>>getTicketNuevos(){
        try{
            return ResponseEntity.ok(this.sdkBus.getTicketNuevos());

        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }


}

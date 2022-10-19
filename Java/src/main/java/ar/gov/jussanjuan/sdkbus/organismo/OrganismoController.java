package ar.gov.jussanjuan.sdkbus.organismo;

import ar.gov.jussanjuan.sdkbus.sdk.SDKBus;
import ar.gov.jussanjuan.sdkbus.dto.BusResponse;
import ar.gov.jussanjuan.sdkbus.dto.DataResponse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Map;

@RestController
@RequestMapping("/organismos")
public class OrganismoController {
    @Autowired
    SDKBus sdkBus;

    @GetMapping("")
    ResponseEntity<BusResponse<DataResponse<Organismo>>> getOrganismos(@RequestParam Map<String, String> allRequestParams){
        try{
            return ResponseEntity.ok(this.sdkBus.findOrganismos(allRequestParams));
        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }
}

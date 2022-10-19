package ar.gov.jussanjuan.sdkbus.dependencia;

import ar.gov.jussanjuan.sdkbus.dto.BusResponse;
import ar.gov.jussanjuan.sdkbus.dto.DataResponse;
import ar.gov.jussanjuan.sdkbus.dto.DependenciaDataResponse;
import ar.gov.jussanjuan.sdkbus.sdk.SDKBus;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Map;

@RestController
@RequestMapping("/dependencias")
public class DependenciaController {
    @Autowired
    SDKBus sdkBus;

    @GetMapping("")
    ResponseEntity<BusResponse<DataResponse<Dependencia>>>getDependencias(@RequestParam Map<String, String> allRequestParams){
        try{
            return ResponseEntity.ok(this.sdkBus.findDependencias(allRequestParams));
        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }
    @PutMapping("")
    ResponseEntity<BusResponse<DependenciaDataResponse>>putDependencia(@RequestBody Dependencia dependencia){
        try{
            return ResponseEntity.ok(this.sdkBus.putDependecia(dependencia));

        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }

    @DeleteMapping("")
    ResponseEntity<BusResponse<DependenciaDataResponse>>putDependencia(@RequestBody DependenciaDataResponse dependencia){
        try{
            return ResponseEntity.ok(this.sdkBus.deleteDependencia(dependencia));

        }catch (Exception e){
            throw new RuntimeException(e.getMessage());
        }
    }
}

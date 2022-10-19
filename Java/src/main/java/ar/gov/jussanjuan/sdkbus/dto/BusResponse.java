package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@AllArgsConstructor
@NoArgsConstructor
@Data
public class BusResponse<RD>{
    private Boolean status;
    private String message;
    private RD data;
    private ErrorDetail errorDetail;

}

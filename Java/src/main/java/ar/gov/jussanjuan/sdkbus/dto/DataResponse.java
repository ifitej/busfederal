package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DataResponse<R> {
    private List<R> items;
    private Integer totalRegistros;
}

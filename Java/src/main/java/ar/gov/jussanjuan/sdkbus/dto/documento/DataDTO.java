package ar.gov.jussanjuan.sdkbus.dto.documento;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class DataDTO {
    private String data_base64;
    private String sha_256_data;
}

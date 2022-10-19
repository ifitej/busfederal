package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@AllArgsConstructor
@NoArgsConstructor
@Data
public class LoginResponseResult {
    private String access_token;
    private Integer expires_in;
    private Integer refresh_expires_in;
    private String token_type;
    private Integer not_before_policy;
    private String scope;
}

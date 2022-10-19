package ar.gov.jussanjuan.sdkbus.config;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.context.annotation.Configuration;

@Configuration
@ConfigurationProperties(prefix = "bus-federal")
@NoArgsConstructor
@AllArgsConstructor
@Data
public class CredentialProperties {
    private String clientid;
    private String clientsecret;

}

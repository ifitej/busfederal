package ar.gov.jussanjuan.sdkbus.config;

import org.springframework.http.client.ClientHttpResponse;
import org.springframework.web.client.ResponseErrorHandler;

import java.io.IOException;

public class HttpErrorHandler implements ResponseErrorHandler {
    @Override
    public void handleError(ClientHttpResponse response) throws IOException {
        // your error handling here
    }

    @Override
    public boolean hasError(ClientHttpResponse response) throws IOException {
        throw new RuntimeException(response.getStatusCode().toString());
    }
}

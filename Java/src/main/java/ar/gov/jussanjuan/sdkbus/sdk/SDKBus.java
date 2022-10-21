package ar.gov.jussanjuan.sdkbus.sdk;

import ar.gov.jussanjuan.sdkbus.config.CredentialProperties;
import ar.gov.jussanjuan.sdkbus.dto.DependenciaDataResponse;
import ar.gov.jussanjuan.sdkbus.dto.LoginResponseResult;
import ar.gov.jussanjuan.sdkbus.dto.documento.DocumentoDataResponse;
import ar.gov.jussanjuan.sdkbus.dto.documento.DocumentoEnviarDTO;
import ar.gov.jussanjuan.sdkbus.dto.ticket.DataTicketDTO;
import ar.gov.jussanjuan.sdkbus.dto.ticket.DataTicketNuevoDTO;
import ar.gov.jussanjuan.sdkbus.utils.RequiresBusLogin;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.node.ObjectNode;
import ar.gov.jussanjuan.sdkbus.dto.BusResponse;
import ar.gov.jussanjuan.sdkbus.dto.DataResponse;
import ar.gov.jussanjuan.sdkbus.organismo.Organismo;
import ar.gov.jussanjuan.sdkbus.dependencia.Dependencia;
import org.apache.tomcat.util.codec.binary.Base64;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.ParameterizedTypeReference;
import org.springframework.core.env.Environment;
import org.springframework.http.*;
import org.springframework.stereotype.Service;
import org.springframework.util.LinkedMultiValueMap;
import org.springframework.util.MultiValueMap;
import org.springframework.web.client.HttpClientErrorException;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.util.UriComponentsBuilder;

import java.net.URI;
import java.sql.Timestamp;
import java.util.Date;
import java.util.Iterator;
import java.util.Map;

@Service
public class SDKBus {

    @Autowired
    private Environment environment;

    @Autowired
    private CredentialProperties credentialProperties;

    private String jwt = "";
    RestTemplate restTemplate = new RestTemplate();

    public boolean login() {
        ResponseEntity<LoginResponseResult> response = null;
        // According OAuth documentation we need to send the client id and secret key in the header for authentication
        String credentials = credentialProperties.getClientid()+":"+ credentialProperties.getClientsecret();
        String encodedCredentials = new String(Base64.encodeBase64(credentials.getBytes()));

        HttpHeaders headers = new HttpHeaders();
        headers.add("Authorization", "Basic " + encodedCredentials);
        headers.setContentType(MediaType.APPLICATION_FORM_URLENCODED);

        MultiValueMap<String, String> map= new LinkedMultiValueMap<String, String>();
        map.add("grant_type", "client_credentials");
        map.add("username", credentialProperties.getClientid());
        map.add("password", credentialProperties.getClientsecret());

        HttpEntity<MultiValueMap<String, String>> request = new HttpEntity<MultiValueMap<String, String>>(map, headers);
        response = this.restTemplate.postForEntity(environment.getProperty("bus-federal.access-token-url"), request, LoginResponseResult.class);
        if(response.hasBody()){
            this.jwt = response.getBody().getAccess_token();
            return true;
        }else{
            throw new RuntimeException("No se pudo obtener el token");
        }
    }


    @RequiresBusLogin
    public BusResponse<DataResponse<Dependencia>> findDependencias(Map<String, String> allRequestParams){
        UriComponentsBuilder builder = UriComponentsBuilder.fromUriString(environment.getProperty("bus-federal.api-url") +"/dependencias");
        Iterator var = allRequestParams.entrySet().iterator();
        while (var.hasNext()){
            Map.Entry<String, String> entry = (Map.Entry)var.next();
            builder.queryParam(entry.getKey(), entry.getValue());
        }
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<DataResponse<Dependencia>>> r = null;
        try{
            r = this.exchange(builder.build().toUri(), HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<DataResponse<Dependencia>>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DependenciaDataResponse> putDependecia(Dependencia dependencia){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(dependencia, headers);
        ResponseEntity<BusResponse<DependenciaDataResponse>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/dependencias", HttpMethod.PUT, entity, new ParameterizedTypeReference<BusResponse<DependenciaDataResponse>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DocumentoDataResponse> enviarDocumento(DocumentoEnviarDTO documento){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(documento, headers);
        ResponseEntity<BusResponse<DocumentoDataResponse>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/enviar", HttpMethod.POST, entity, new ParameterizedTypeReference<BusResponse<DocumentoDataResponse>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DocumentoEnviarDTO> getDocumento(String uuid){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<DocumentoEnviarDTO>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/documento?Uuid=" + uuid, HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<DocumentoEnviarDTO>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<String> getDocumentoLink(String uuid){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<String>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/documento/link?Uuid=" + uuid, HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<String>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<String> getDocumentoData(String uuid){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<String>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/documento/data?Uuid=" + uuid, HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<String>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<String> getDocumentoBinario(String uuid){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<String>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/documento/binario?Uuid=" + uuid, HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<String>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DependenciaDataResponse> deleteDependencia(DependenciaDataResponse dependencia){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(dependencia, headers);
        ResponseEntity<BusResponse<DependenciaDataResponse>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/dependencias", HttpMethod.DELETE, entity, new ParameterizedTypeReference<BusResponse<DependenciaDataResponse>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }

    public <RES> ResponseEntity<RES> exchange(URI uri, HttpMethod method, HttpEntity httpEntity, ParameterizedTypeReference<RES> parametrizedTypeReference){
        return this.restTemplate.exchange(uri, method, httpEntity, parametrizedTypeReference);
    }

    public <RES> ResponseEntity<RES> exchange(String url, HttpMethod method, HttpEntity httpEntity, ParameterizedTypeReference<RES> parametrizedTypeReference){
        return this.restTemplate.exchange(url, method, httpEntity, parametrizedTypeReference);
    }
    @RequiresBusLogin
    public BusResponse<DataResponse<Organismo>> findOrganismos(Map<String, String> allRequestParams){
        UriComponentsBuilder builder = UriComponentsBuilder.fromUriString(environment.getProperty("bus-federal.api-url") +"/organismos");
        Iterator var = allRequestParams.entrySet().iterator();
        while (var.hasNext()){
            Map.Entry<String, String> entry = (Map.Entry)var.next();
            builder.queryParam(entry.getKey(), entry.getValue());
        }
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<DataResponse<Organismo>>> r = null;
        try{
            r = this.exchange(builder.build().toUri(), HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<DataResponse<Organismo>>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DataTicketDTO> getTicket(String uuid){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<DataTicketDTO>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/ticket?Uuid=" + uuid, HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<DataTicketDTO>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }
    @RequiresBusLogin
    public BusResponse<DataTicketNuevoDTO> getTicketNuevos(){
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.set("Authorization", "Bearer "+this.jwt);
        HttpEntity entity = new HttpEntity(headers);
        ResponseEntity<BusResponse<DataTicketNuevoDTO>> r = null;
        try{
            r = this.exchange(environment.getProperty("bus-federal.api-url") + "/ticket/nuevos", HttpMethod.GET, entity, new ParameterizedTypeReference<BusResponse<DataTicketNuevoDTO>>() {});
            return r.getBody();
        }catch(Exception e){
            if(e instanceof HttpClientErrorException){
                if(((HttpClientErrorException.Unauthorized) e).getRawStatusCode()==401){
                    this.login();
                }else{
                    throw new RuntimeException(e.getMessage());
                }
            }else{
                throw new RuntimeException(e.getMessage());
            }
        }
        return null;
    }

    public Boolean isValid() {
        if (this.jwt.isEmpty()) {
            return false;
        } else {
            String[] arre = this.jwt.split("\\.");
            String jsonPayload = new String(java.util.Base64.getDecoder().decode(arre[1]));
            System.out.printf(jsonPayload);
            try{
                final ObjectNode node = new ObjectMapper().readValue(jsonPayload, ObjectNode.class);
                if(node.has("exp")){
                    Timestamp stamp = new Timestamp(node.get("exp").asLong() * 1000L);
                    return stamp.compareTo(new Date()) == -1 ? false : true;
                }else{
                    return false;
                }
            }catch(JsonProcessingException je){
                return false;
            }
        }
    }

    public void checkToken() {
        if (!this.isValid()) {
            this.login();
        }
    }
}

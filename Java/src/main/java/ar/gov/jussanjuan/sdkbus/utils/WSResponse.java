package ar.gov.jussanjuan.sdkbus.utils;

import java.util.Date;
import java.util.List;
import java.util.Objects;

public class WSResponse<T> {
    protected Date serverTime;
    private T result;
    private List<String> messages;
    private String path;
    private Boolean success;
    private Integer statusCode;
    private String statusMessage;

    protected WSResponse(WSResponseBuilder wsResponseBuilder) {
        Objects.requireNonNull(wsResponseBuilder);
        this.serverTime = wsResponseBuilder.serverTime;
        this.success = wsResponseBuilder.success;
        this.statusCode = wsResponseBuilder.statusCode;
        this.statusMessage = wsResponseBuilder.statusMessage;
        this.result = (T) wsResponseBuilder.result;
        this.path = wsResponseBuilder.path;
        this.messages = wsResponseBuilder.messages;
    }

    public WSResponse() {
    }

    public Date getServerTime() {
        return this.serverTime;
    }

    public void setServerTime(Date serverTime) {
        this.serverTime = serverTime;
    }

    public T getResult() {
        return this.result;
    }

    public void setResult(T result) {
        this.result = result;
    }

    public List<String> getMessages() {
        return this.messages;
    }

    public void setMessages(List<String> messages) {
        this.messages = messages;
    }

    public String getPath() {
        return this.path;
    }

    public void setPath(String path) {
        this.path = path;
    }

    public Boolean getSuccess() {
        return this.success;
    }

    public void setSuccess(Boolean success) {
        this.success = success;
    }

    public Integer getStatusCode() {
        return this.statusCode;
    }

    public void setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
    }

    public String getStatusMessage() {
        return this.statusMessage;
    }

    public void setStatusMessage(String statusMessage) {
        this.statusMessage = statusMessage;
    }
}

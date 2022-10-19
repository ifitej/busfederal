package ar.gov.jussanjuan.sdkbus.utils;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class WSResponseBuilder<T> {
    protected List<String> messages = new ArrayList<String>();
    protected String messageCode;
    protected String path;
    protected Boolean success;
    protected T result;
    protected Date serverTime;
    protected Integer statusCode;
    protected String statusMessage;

    public WSResponseBuilder() {
    }

    public WSResponseBuilder addMessage(String message) {
        this.messages.add(message);
        return this;
    }

    public WSResponseBuilder addMessages(List<String> message) {
        if (message != null) {
            this.messages.addAll(message);
        }

        return this;
    }

    public WSResponseBuilder success(Boolean success) {
        this.success = success;
        return this;
    }

    public WSResponseBuilder path(String path) {
        this.path = path;
        return this;
    }

    public WSResponseBuilder result(T result) {
        this.result = result;
        return this;
    }

    public WSResponseBuilder statusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }

    public WSResponseBuilder statusMessage(String statusMessage) {
        this.statusMessage = statusMessage;
        return this;
    }

    public WSResponse makeSuccessResponse(String path, T result) {
        this.success = true;
        this.statusCode = 200;
        this.statusMessage = "Success";
        this.addMessage("Operación ejecutada con exito");
        this.serverTime = new Date();
        this.path = path;
        this.result = result;
        return new WSResponse<T>(this);
    }

    public WSResponse makeSuccessResponse(String path) {
        return this.makeSuccessResponse(path, null);
    }

    public WSResponse build() {
        this.serverTime = new Date();
        return new WSResponse<T>(this);
    }
}

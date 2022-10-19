package ar.gov.jussanjuan.sdkbus.config;

import ar.gov.jussanjuan.sdkbus.utils.WSResponse;
import ar.gov.jussanjuan.sdkbus.utils.WSResponseBuilder;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestControllerAdvice;

import javax.servlet.http.HttpServletRequest;
import java.util.ArrayList;
import java.util.List;

@RestControllerAdvice
public class ExceptionHandlerController {
    private static Logger log = LoggerFactory.getLogger(ExceptionHandlerController.class);

    @ExceptionHandler(Exception.class)
    @ResponseStatus(value = HttpStatus.INTERNAL_SERVER_ERROR)
    public @ResponseBody
    WSResponse handleException(final Exception exception, final HttpServletRequest request) {
        log.error("ERROR GENERAL ", exception);
        List<String> erros = new ArrayList<String>();
        erros.add(exception.getMessage());
        return new WSResponseBuilder<>()
                .addMessages(erros)
                .success(false)
                .statusCode(HttpStatus.INTERNAL_SERVER_ERROR.value())
                .statusMessage(HttpStatus.INTERNAL_SERVER_ERROR.name())
                .path(request.getRequestURI())
                .build();
    }

    @ExceptionHandler(RuntimeException.class)
    @ResponseStatus(value = HttpStatus.OK)
    public @ResponseBody
    ResponseEntity<WSResponse> handleBusinessException(final RuntimeException exception, final HttpServletRequest request) {
        log.error("ERROR GENERAL ", exception);
        WSResponse r = new WSResponseBuilder().build();
        r.getMessages().add(exception.getMessage());
        r.setPath(request.getRequestURI());
        r.setStatusCode(200);
        r.setSuccess(false);
        return ResponseEntity.ok(r);
    }

    @ExceptionHandler(IllegalArgumentException.class)
    @ResponseStatus(value = HttpStatus.BAD_REQUEST)
    public @ResponseBody
    WSResponse handleIllegalArgument(final IllegalArgumentException exception, final HttpServletRequest request) {
        log.error("ERROR EN DATOS DE ENTRADA ", exception);
        return new WSResponseBuilder<>()
                .addMessage(exception.getMessage())
                .success(false)
                .statusCode(HttpStatus.BAD_REQUEST.value())
                .statusMessage(HttpStatus.BAD_REQUEST.name())
                .path(request.getRequestURI())
                .build();
    }
}
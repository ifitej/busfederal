package ar.gov.jussanjuan.sdkbus.login;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/login")
public class LoginController {
    @Autowired
    ar.gov.jussanjuan.sdkbus.sdk.SDKBus SDKBus;

    @GetMapping("")
    public boolean login(){
        return this.SDKBus.login();
    }
}

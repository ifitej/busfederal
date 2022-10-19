package ar.gov.jussanjuan.sdkbus.utils;

import ar.gov.jussanjuan.sdkbus.sdk.SDKBus;
import org.springframework.stereotype.Component;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;


@Component
@Aspect
public class AspectSDK {
    public AspectSDK(){}

    @Before("@annotation(ar.gov.jussanjuan.sdkbus.utils.RequiresBusLogin)")
    public void verifyLogin(JoinPoint jp) {
        SDKBus sdkBus = (SDKBus) jp.getThis();

        try {
            sdkBus.login();
        } catch (Exception var4) {
            var4.printStackTrace();
        }

    }

}

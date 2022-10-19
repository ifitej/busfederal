package ar.gov.jussanjuan.sdkbus.utils;

import java.sql.Timestamp;
import java.util.Date;

public class JWTPayload {
    private Long exp;

    public JWTPayload() {
    }

    public Long getExp() {
        return this.exp;
    }

    public void setExp(Long exp) {
        this.exp = exp;
    }

    public Date getDateExpired() {
        Timestamp stamp = new Timestamp(this.exp * 1000L);
        return new Date(stamp.getTime());
    }
}

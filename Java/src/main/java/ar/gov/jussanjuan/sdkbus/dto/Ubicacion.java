package ar.gov.jussanjuan.sdkbus.dto;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@NoArgsConstructor
@AllArgsConstructor
@Data
public class Ubicacion {
    private String ciudad;
    private String calle;
    private String numero;
    private String piso_dpto;
    private String cp;
    private String nombre_agrup_geo;
    private String tipo_agrup_geo;
    private Georeferencia georef;

}

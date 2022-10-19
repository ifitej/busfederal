package ar.gov.jussanjuan.sdkbus.documento;

import ar.gov.jussanjuan.sdkbus.dto.BusResponse;
import ar.gov.jussanjuan.sdkbus.dto.documento.DataDTO;
import ar.gov.jussanjuan.sdkbus.dto.documento.DocumentoDataResponse;
import ar.gov.jussanjuan.sdkbus.dto.documento.DocumentoEnviarDTO;
import ar.gov.jussanjuan.sdkbus.sdk.SDKBus;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;
import java.security.NoSuchAlgorithmException;

@RestController
@RequestMapping("/documento")
public class DocumentoController {

    private final Logger logger = LoggerFactory.getLogger(DocumentoController.class);

    @Autowired
    private SDKBus sdkBus;

    @Autowired
    private DocumentoService documentoService;

    @PostMapping("/enviar")
    public ResponseEntity<BusResponse<DocumentoDataResponse>> uploadFile(@RequestBody DocumentoEnviarDTO documento) throws IOException, NoSuchAlgorithmException {
        BusResponse<DocumentoDataResponse> response = this.sdkBus.enviarDocumento(documento);
        return ResponseEntity.ok(response);
    }

    @PostMapping("/get-payload-and-hash")
    public ResponseEntity<DataDTO> getPayloadAndHash(@RequestParam("file") MultipartFile uploadfile) throws IOException, NoSuchAlgorithmException {
        DataDTO dataDocumento = this.documentoService.getDataFile(uploadfile);
        return ResponseEntity.ok(dataDocumento);
    }

    @GetMapping("")
    public ResponseEntity<BusResponse<DocumentoEnviarDTO>> getDocumento(@RequestParam String Uuid) {
        BusResponse<DocumentoEnviarDTO> response = this.sdkBus.getDocumento(Uuid);
        return ResponseEntity.ok(response);
    }

    @GetMapping("/binario")
    public ResponseEntity<BusResponse<String>> getDocumentoBinario(@RequestParam String Uuid) {
        BusResponse<String> response = this.sdkBus.getDocumentoBinario(Uuid);
        return ResponseEntity.ok(response);
    }

    @GetMapping("/link")
    public ResponseEntity<BusResponse<String>> getDocumentoLink(@RequestParam String Uuid) {
        BusResponse<String> response = this.sdkBus.getDocumentoLink(Uuid);
        return ResponseEntity.ok(response);
    }

    @GetMapping("/data")
    public ResponseEntity<BusResponse<String>> getDocumentoData(@RequestParam String Uuid) {
        BusResponse<String> response = this.sdkBus.getDocumentoData(Uuid);
        return ResponseEntity.ok(response);
    }

}

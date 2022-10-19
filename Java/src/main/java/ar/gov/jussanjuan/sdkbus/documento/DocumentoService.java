package ar.gov.jussanjuan.sdkbus.documento;

import com.google.common.hash.Hashing;
import ar.gov.jussanjuan.sdkbus.dto.documento.DataDTO;
import org.springframework.stereotype.Service;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Base64;

@Service
public class DocumentoService{
    public DataDTO getDataFile(MultipartFile file) throws IOException {
        byte[] bytes = file.getBytes();
        byte[] encoded = Base64.getEncoder().encode(bytes);
        String sha256hex = Hashing.sha256()
                .hashString(new String(encoded), StandardCharsets.UTF_8)
                .toString();
        return new DataDTO(new String(encoded), sha256hex);
    }
}

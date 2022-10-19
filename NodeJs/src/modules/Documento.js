class DocumentoModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	obtener = async (params) => {
		return this.restClient.get('/documento', {
			params
		});
	};

	obtenerBinario = async (params) => {
		return this.restClient.get('/documento/binario', {
			params
		});
	};

	obtenerData = async (params) => {
		return this.restClient.get('/documento/data', {
			params
		});
	};

	obtenerLink = async (params) => {
		return this.restClient.get('/documento/link', {
			params
		});
	};



}

export default DocumentoModule;

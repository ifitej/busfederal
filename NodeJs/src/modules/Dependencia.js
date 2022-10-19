class DependenciaModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	buscar = async (params) => {
		return this.restClient.get('/dependencias', {
			params
		});
	};

	guardar = async (params) => {
		return this.restClient.put('/dependencias', params);
	};

	eliminar = async(params) => {
		return this.restClient.delete('/dependencias', {
			data: params
		});
	};
}

export default DependenciaModule;

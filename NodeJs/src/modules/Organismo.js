class OrganismoModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	buscar = async (params) => {
		return this.restClient.get('/organismos', {
			params,
		});
	};

	sincronizar = async (params) => {
		return this.restClient.post('/organismos/sincronizar', {
			params
		});
	};
}

export default OrganismoModule;
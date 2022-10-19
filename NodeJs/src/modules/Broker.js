class BrokerModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	enviarDocumento = async (payload) => {
		return this.restClient.post('/Broker/EnviarDocumento', {
			body: payload
		});
	};
}

export default BrokerModule;

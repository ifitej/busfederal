class TicketModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	obtener(payload) {
		return this.restClient.get('/ticket', { params: payload });
	}

	buscar(payload) {
		return this.restClient.post('/ticket/buscar', {
			data: payload,
		});
	}

	nuevos() {
		return this.restClient.post('/ticket/nuevos');
	}
}

export default TicketModule;

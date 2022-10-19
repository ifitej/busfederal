import { Dependencia, Organismo, Status, Ticket, Documento, Broker } from './modules/index.js';

import { RestClient as initRestClient  } from './RestClient.js';

class BordeClient {
	restClient = null;
	dependenciaModule = null;
	organismoModule = null;
	statusModule = null;
	ticketModule = null;
	documentoModule = null;
	brokerModule = null;

	async init(config) {
		console.log('INIT BORDE CLIENT');
		const client = await initRestClient(config);

		this.restClient = client;
	}

	dependencia() {
		if (this.dependenciaModule === null) {
			this.dependenciaModule = new Dependencia(this.restClient);
		}

		return this.dependenciaModule;
	}

	organismo() {
		if (this.organismoModule === null) {
			this.organismoModule = new Organismo(this.restClient);
		}

		return this.organismoModule;
	}

	status() {
		if (this.statusModule === null) {
			this.statusModule = new Status(this.restClient);
		}

		return this.statusModule;
	}

	ticket(){
		if (this.ticketModule === null) {
			this.ticketModule = new Ticket(this.restClient);
		}

		return this.ticketModule;
	}

	documento(){
		if (this.documentoModule === null) {
			this.documentoModule = new Documento(this.restClient);
		}

		return this.documentoModule;
	}

	broker() {
		if (this.brokerModule === null) {
			this.brokerModule = new Broker(this.restClient);
		}

		return this.brokerModule;
	}

}

export default BordeClient;

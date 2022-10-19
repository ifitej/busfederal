class StatusModule {
	restClient;
	data;

	constructor(restClient) {
		this.restClient = restClient;
	}

	ping() {
		return this.restClient.get('status/ping');
	}

	ready() {
		return this.restClient.get('/status/ready');
	}

	version() {
		return this.restClient.get('/status/version');
	}

	getAuthorityUrl() {
		return this.restClient.get('/Api/GetAuthorityUrl');
	}
}

export default StatusModule;

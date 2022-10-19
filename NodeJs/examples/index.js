import dotenv from 'dotenv';
dotenv.config();

import BordeClient from '../src/Borde.js';

const config = {
	url: process.env.BORDE_URL,
	clientId: process.env.BORDE_CLIENT_ID,
	secretKey: process.env.BORDE_SECRET_KEY,
};

const borde = new BordeClient();

await borde.init(config);

console.log('************************************************************************');
console.log('***************************EJEMPLOS STATUS******************************');
console.log('************************************************************************', '\n');


const { data: ping, status: status_ping } = await borde.status().ping();
console.log('GET /status/ping ->', status_ping, ping, '\n');

const { data: ready, status: status_ready } = await borde.status().ready();
console.log('GET /status/ready ->', status_ready, ready, '\n');

const { data: version, status: status_version } = await borde.status().version();
console.log('GET /status/version ->', status_version, version, '\n');

console.log('');
console.log('************************************************************************');
console.log('**************************EJEMPLOS ORGANISMO****************************');
console.log('************************************************************************', '\n');

const { data: organismo_buscar, status: status_organismo_buscar } = await borde
	.organismo()
	.buscar({ codigo_organismo: config.clientId });
console.log('GET /organismos/clear ->', status_organismo_buscar, organismo_buscar, '\n');

// sincronizar 
const { data: organismo_sincronizar, status: status_organismo_sincronizar } = await borde
	.organismo()
	.sincronizar({ codigo_organismo: config.clientId });
console.log('POST /organismos/sincronizar ->', status_organismo_sincronizar, organismo_sincronizar, '\n');



console.log('************************************************************************');
console.log('*************************EJEMPLOS DEPENDENCIA***************************');
console.log('************************************************************************', '\n');

const { data: dependencia_buscar, status: status_dependencia_buscar } = await borde
	.dependencia()
	.buscar({ codigo_organismo: 'PJTDF-AR-V-PUB' });
console.log('GET /dependencia/buscar ->', status_dependencia_buscar, dependencia_buscar, '\n');

const data_new_dependencia = {
	id_interno: '123',
	codigo_dependencia: '123',
	nombre: 'adipisicing Excepteur',
	descripcion: 'elit exercitation adipisicing cillum',
	fuero: 'nulla dolor labore consequat',
	instancia: 'adipisicing velit dolor eiusmod consequat',
	ubicacion: {
		ciudad: 'Ushuaia',
		calle: 'sed consequat',
		numero: 'dolor',
		piso_dpto: 'proident sint culpa velit',
		cp: 'voluptate reprehen',
		nombre_agrup_geo: 'nisi commodo ut esse',
		tipo_agrup_geo: 'Excepteur labo',
		georef: {
			centroide: {
				lat: 'in labore ad ullamco consequat',
				lon: 'qui anim',
			},
		},
	},
	datos_contacto: {
		correo_electronico: 'dependencia_123@justierradelfuego.gov.ar',
		nombre_completo: 'dolor do Ut sed labore',
		telefono: 'nulla eiusmod',
		telefono_urgencia: 'culpa sed consequat cupidatat',
		telefono_guardia: 'amet irure',
	},
};

try {
	const {
		data: dependencia_store,
		status: status_dependencia_store
	} = await borde.dependencia().guardar(data_new_dependencia);
	console.log('GET /dependencia/guardar ->', status_dependencia_store, dependencia_store, '\n');
} catch (error) {
	console.log('ERROR', error.code);
}

const { data: dependencia_eliminar, status: status_dependencia_eliminar } = await borde
	.dependencia()
	.buscar();
console.log('GET /dependencia/eliminar ->', status_dependencia_eliminar, dependencia_eliminar, '\n');


console.log('************************************************************************');
console.log('**************************EJEMPLOS DOCUMENTO****************************');
console.log('************************************************************************', '\n');

const { data: documento_obtener, status: status_documento_obtener } = await borde.documento().obtener({
	uuid: 12313123,
});
console.log('GET /documento ->', status_documento_obtener, documento_obtener, '\n');

const { data: documento_obtener_binario, status: status_documento_obtener_binario } = await borde
	.documento()
	.obtenerBinario({
		uuid: 12313123,
	});
console.log('GET /documento/binario ->', status_documento_obtener_binario, documento_obtener_binario, '\n');

const { data: documento_obtener_data, status: status_documento_obtener_data } = await borde.documento().obtenerData({
	uuid: 12313123,
});
console.log('GET /documento/data ->', status_documento_obtener_data, documento_obtener_data, '\n');

const { data: documento_obtener_link, status: status_documento_obtener_link } = await borde.documento().obtenerLink({
	uuid: 12313123,
});
console.log('GET /documento/link ->', status_documento_obtener_link, documento_obtener_link, '\n');

console.log('************************************************************************');
console.log('***************************EJEMPLOS TICKET******************************');
console.log('************************************************************************', '\n');

const ticket_obtener_payload = {
	uuid_respuesta: 'sunt e',
	fechaDesde: '2017-12-25T12:17:28.475Z',
	fechaHasta: '2022-12-30T16:49:04.933Z',
	origen: {
		nro_causa: 'labore',
		dependencia: {
			codigo_organismo: 'esse voluptate aute',
			codigo_dependencia: 'labore laborum laboris',
		},
	},
	destino: {
		nro_causa: 'exercitati',
		dependencia: {
			codigo_organismo: 'sit mollit consectetur in',
			codigo_dependencia: 'Lorem minim in',
		},
	},
	numeroPagina: 1,
	registrosPorPagina: 100,
};

const { data: ticket_obtener, status: status_ticket_obtener } = await borde.ticket().buscar(ticket_obtener_payload);
console.log('GET /ticket ->', status_ticket_obtener, ticket_obtener, '\n');

try {
	const { data: ticket_nuevos, status: status_ticket_nuevos } = await borde.ticket().nuevos();
	console.log('POST /ticket/nuevos ->', status_ticket_nuevos, ticket_nuevos, '\n');
} catch (error) {
	console.log('POST /ticket/nuevos -> ', error.code, '\n');
}

console.log('************************************************************************');
console.log('***************************EJEMPLOS BROKER******************************');
console.log('************************************************************************', '\n');

const payload_broker_enviar_documento = {
	data: {
		data_base64: 'dolore ex nulla',
		sha_256_data: 'nostrud culpa aliquip occaecat',
	},
	uuid_respuesta: 'aliqua ut voluptat',
	origen: {
		nro_causa: 'aliqua ipsum',
		caratula: 'Duis qui sit',
		codigo_dependencia: 'laborum deserunt Excepte',
	},
	destino: {
		nro_causa: 'irure ips',
		caratula: 'cupidatat',
		dependencia: {
			codigo_organismo: 'non veniam labore in',
			codigo_dependencia: 'magna ad eiusmod deserunt laborum',
		},
	},
	documento: {
		payload_base64: 'minim deserunt sit',
		nombre_documento: 'sit cillum deserunt Lorem',
		tipo_documento: 'amet culpa',
		sha_256_payload: 'voluptate eiusmod Lorem incididunt',
	},
};

const { data: broker_enviar_documento, status: status_broker_enviar_documento } = await borde
	.broker()
	.enviarDocumento(payload_broker_enviar_documento);

console.log('POST /broker/enviar_documento ->', status_broker_enviar_documento, broker_enviar_documento, '\n');


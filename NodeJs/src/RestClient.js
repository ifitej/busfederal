import axios from 'axios';
import qs from 'qs';


const setInterceptors = (client) => {

	client.interceptors.request.use((config) => {
		// handle request 
		const { baseURL, headers, params, method, url, data} = config;

		const request_data = {
			baseURL,
			headers,
			params,
			data,
			method,
			url,
		};

		// console.log('config', request_data);

		return config;
	});

	client.interceptors.response.use(
		(response) => {
			// handle response

			return response;
		},
		(error) => {
			// error handling
			if (error.response.status === 401) {
				// refresh token ?
			}
			return Promise.reject(error);
		}
	);
};

const getAuthUrl = async (baseUrl) => {
	try {
		const { data: response } = await axios.get(`${baseUrl}/api/GetAuthorityUrl`);

		return `${response.data}/protocol/openid-connect/token`;
	} catch (error) {
		console.error(error);
	}
};

const getAccessToken = async (config) => {
	try {
		const { url: baseUrl, clientId, secretKey } = config;

		const authUrl = await getAuthUrl(baseUrl);

		const payload = qs.stringify({
			client_id: clientId,
			client_secret: secretKey,
			grant_type: 'client_credentials',
		});

		const { data } = await axios.post(authUrl, payload, {
			headers: {
				'Content-Type': 'application/x-www-form-urlencoded',
			},
			withCredentials: true,
		});

		return data.access_token;
	} catch (error) {
		console.error(error);
	}
};

export const RestClient = async (config) => {
	const axiosInstance = axios.create({
		baseURL: config.url,
	});

	// set interceptors for requests and responses
	setInterceptors(axiosInstance);

	// set access_token 
	const access_token = await getAccessToken(config);
	axiosInstance.defaults.headers.Authorization = `Bearer ${access_token}`;

	return axiosInstance;
};

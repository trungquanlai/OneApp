import axios from 'axios';
import store from '@/store';
import router from '@/router/index.js';

class Http {
    HttpClient;
    baseUrl = 'https://jsonplaceholder.typicode.com/';

    constructor() {
        this.HttpClient = axios.create({
            baseURL: this.baseUrl,
            responseType: 'json',
            withCredentials: false,
            headers: {
                'Content-Type': 'application/json',
            },
        });

        this.HttpClient.interceptors.response.use(
            (response) => response,
            (error) => {
                if (error.response.status == 401) {
                    this.error('Unauthorized Request!');
                    router.push('/login');
                }

                return Promise.reject(error);
            },
        );
    }

    async get(endpoint, callback) {
        debugger;
        await this.send('get', endpoint, null, callback);
    }

    async patch(endpoint, data, callback) {
        await this.send('patch', endpoint, data, callback);
    }

    async post(endpoint, data, callback) {
        await this.send('post', endpoint, data, callback);
    }

    async delete(endpoint, callback) {
        await this.send('delete', endpoint, null, callback);
    }

    async send(verb, endpoint, data, callback) {
        debugger;
        await this.HttpClient.request({
            method: verb,
            url: endpoint,
            data: data,
        })
            .then((response) => {
                // store.commit('finishLoading');
                debugger;

                if (response.data) callback(response.data);
                else this.error(response.data.message);
            })
            .catch((errResp) => {
                // store.commit('finishLoading');
            });
    }

    info(message) {
        // store.commit('updateNotify', {
        //     itemType: 'info',
        //     text: message.toString(),
        // });
    }

    error(message) {
        // store.commit('updateNotify', {
        //     itemType: 'error',
        //     text: message.toString(),
        // });
    }
}

export default new Http();
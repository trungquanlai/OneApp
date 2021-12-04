import http from '@/services/http.service';

import { GET_ORDERS } from '@/store/orders/actions.type.js';

import { SET_ORDERS } from '@/store/orders/mutations.type.js';

const state = {
    orders: { id: '123' },
};

const getters = {
    orders: (state) => state.orders,
};

const actions = {
    [GET_ORDERS]({ commit }) {
        http.get('todos/1', (callback) => {
            commit(SET_ORDERS, callback);
        });
    },
};

const mutations = {
    [SET_ORDERS](state, orders) {
        state.orders = orders;
    },
};

export default {
    state,
    getters,
    actions,
    mutations,
};

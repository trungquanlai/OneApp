import Vue from 'vue';
import Vuex from 'vuex';
import orders from '@/store/orders/orders.module.js';

Vue.use(Vuex);

export default new Vuex.Store({
    modules: { orders },
});

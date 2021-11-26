import Vue from 'vue';
import VueRouter from 'vue-router';
import MainScreen from '@/views/MainScreen.vue';
import Dashboard from '@/views/Dashboard.vue';
import Invoices from '@/views/Invoices.vue';
import Kitchen from '@/views/Kitchen.vue';
import Orders from '@/views/Orders.vue';
import Settings from '@/views/Settings.vue';

const originalPush = VueRouter.prototype.push;
VueRouter.prototype.push = function push(location) {
    return originalPush.call(this, location).catch((err) => err);
};

Vue.use(VueRouter);

const routes = [
    // {
    //     path: '/',
    //     name: 'Main Screen',
    //     component: MainScreen,
    // },
    {
        path: '/',
        name: 'Dashboard',
        component: Dashboard,
    },
    {
        path: '/invoices',
        name: 'Invoices',
        component: Invoices,
    },
    {
        path: '/kitchen',
        name: 'Kitchen',
        component: Kitchen,
    },
    {
        path: '/orders',
        name: 'Orders',
        component: Orders,
    },
    {
        path: '/settings',
        name: 'Settings',
        component: Settings,
    },
    {
        path: '/about',
        name: 'About',
        // route level code-splitting
        // this generates a separate chunk (about.[hash].js) for this route
        // which is lazy-loaded when the route is visited.
        component: () =>
            import(/* webpackChunkName: "about" */ '../views/About.vue'),
    },
];

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes,
});

export default router;

<template>
    <div>
        <div
            class="
                nav-container
                d-flex
                justify-content-center
                align-items-center
            "
            @click="$router.push(routeEl)"
        >
            <!-- //d-flex justify-content-center align-items-center nav-container grid3x3-gap-fill -->
            <div class="d-flex single-nav center pt-2 pb-2">
                <div class="center row">
                    <b-icon :icon="iconName"></b-icon>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import Dashboard from '@/views/Dashboard.vue';
import Invoices from '@/views/Invoices.vue';
import Kitchen from '@/views/Kitchen.vue';
import Orders from '@/views/Orders.vue';
import Settings from '@/views/Settings.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
    name: 'Nav',
    data() {
        return { ordersDate: {} };
    },
    props: ['iconName', 'routeEl', 'fGetOrder'],
    methods: {
        ...mapActions(['getOrders']),
    },
    computed: {
        ...mapGetters(['orders']),
    },

    watch: {
        fGetOrder() {
            if (this.fGetOrder) {
                this.getOrders();
                let test = this.orders;
            }
        },
    },
    components: {
        Dashboard,
        Invoices,
        Kitchen,
        Orders,
        Settings,
    },
};
</script>

<style lang="scss">
.single-nav {
    font-size: 3rem;
    color: #939295;
    width: 100px;
    height: 100px;
}

.nav-container {
    background-color: #2c2e38;
    border-bottom: 1px solid #939295;

    :hover {
        background-color: #40424b;
        color: #c67025;
        cursor: pointer;
    }
}
</style>

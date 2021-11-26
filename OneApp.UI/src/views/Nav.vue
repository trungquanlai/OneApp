<template>
    <div>
        <single-nav
            :iconName="dashboard"
            :routeEl="dashboardRoute"
            :class="{
                nav_active: active_el == 1,
            }"
            @click.native="activate(1)"
        />
        <single-nav
            :iconName="orders"
            :routeEl="ordersRoute"
            :class="{
                nav_active: active_el == 2,
            }"
            @click.native="activate(2)"
            :fGetOrder="fGetOrder"
        />
        <single-nav
            :iconName="invoices"
            :routeEl="invoicesRoute"
            :class="{
                nav_active: active_el == 3,
            }"
            @click.native="activate(3)"
        />
        <single-nav
            :iconName="kitchen"
            :routeEl="kitchenRoute"
            :class="{
                nav_active: active_el == 4,
            }"
            @click.native="activate(4)"
        />
        <single-nav
            :iconName="settings"
            :routeEl="settingsRoute"
            :class="{
                nav_active: active_el == 5,
            }"
            @click.native="activate(5)"
        />
    </div>
</template>

<script>
import SingleNav from '../components/NavBar/SingleNav.vue';

export default {
    components: {
        SingleNav,
    },

    data() {
        return {
            dashboard: 'grid3x3-gap-fill',
            dashboardRoute: '/',

            orders: 'cup-straw',
            ordersRoute: 'orders',

            invoices: 'cash',
            invoicesRoute: 'invoices',

            kitchen: 'stopwatch',
            kitchenRoute: 'kitchen',

            settings: 'gear',
            settingsRoute: 'settings',

            active_el: 0,

            fGetOrder: false,
        };
    },

    methods: {
        activate(el) {
            this.active_el = el;

            if (el == 2) this.fGetOrder = true;
        },
    },
};
</script>

<style lang="scss">
.nav_active {
    .nav-container {
        background-color: #40424b !important;
    }

    .single-nav {
        color: #c67025;
    }
}
</style>

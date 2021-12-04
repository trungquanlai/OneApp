<template>
    <div class="app-orders flex-row row">
        <div class="app-orders-items flex-grow-1">
            <OrderItem />
        </div>
        <div class="app-orders-details">This is order details</div>
    </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex';
import OrderItem from '@/components/Orders/OrderItem.vue';

export default {
    components: {
        OrderItem,
    },
    data() {
        return {};
    },
    computed: {
        ...mapGetters(['orders']),
    },
    methods: {
        getOrders() {},
    },
};
</script>

<style lang="scss" scoped>
.app-orders-details {
    border-left: 1px solid black;
    width: 40%;
}
</style>

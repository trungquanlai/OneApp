<template>
    <div>
        <div>This is orders {{ orders }}</div>
    </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex';

export default {
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

<style></style>

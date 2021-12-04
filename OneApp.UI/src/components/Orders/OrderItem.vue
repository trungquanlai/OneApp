<template>
    <div class="order-item">
        <div class="order-item-description">This is order {{ orders }}</div>
        <div class="order-item-footer">$24.00</div>
    </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex';

export default {
    computed: {
        ...mapGetters(['orders']),
    },
};
</script>

<style lang="scss" scoped>
.order-item {
    border: 1px solid black;
}
</style>

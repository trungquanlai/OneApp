<template>
    <div id="app" class="row">
        <Nav class="nav-bar" />
        <router-view class="col" />
    </div>
</template>

<script>
import Nav from './views/Nav.vue';

export default {
    name: 'app',
    components: {
        Nav,
    },
};
</script>

<style lang="scss" scoped>
.row {
    margin-right: 0;
    margin-left: 0;
}

.col-1 {
    padding-right: 0;
    padding-left: 0;
}

.nav-bar {
    background-color: #2c2e38;
}
</style>

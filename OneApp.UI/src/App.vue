<template>
    <div id="app" class="row">
        <Nav class="nav-bar" />
        <div class="row flex-grow-1 flex-column">
            <Header class="app-header mw-100" />
            <router-view class="app-router-view mw-100 flex-grow-1" />
            <Footer class="app-footer mw-100" />
        </div>
    </div>
</template>

<script>
import Nav from './views/Nav.vue';
import Header from './views/Header.vue';
import Footer from './views/Footer.vue';

export default {
    name: 'app',
    components: {
        Nav,
        Header,
        Footer,
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

.app-router-view {
    border-bottom: 1px solid black;
}

.app-header {
    border-bottom: 1px solid black;
    height: 100px;
}

.app-footer {
    height: 100px;
}

.nav-bar {
    background-color: #2c2e38;
    width: 100px;
}
</style>

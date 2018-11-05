import Vue from 'vue';
import BaseComponent from './base.vue';

var data = {
    dashboardData: {
    }
};

new Vue({
    el: '#main',
    data: data,
    components: {
        BaseComponent
    },
    template: '<base-component v-bind="dashboardData"></base-component>',
});

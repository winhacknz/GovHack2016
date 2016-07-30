"use strict";
var router_1 = require('@angular/router');
var home_component_1 = require('./home.component');
var page2_component_1 = require('./page2.component');
var routes = [
    { path: '', component: home_component_1.HomeComponent },
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'page2', component: page2_component_1.Page2Component }
];
exports.appRouterProviders = [
    router_1.provideRouter(routes)
];
//# sourceMappingURL=app.routes.js.map
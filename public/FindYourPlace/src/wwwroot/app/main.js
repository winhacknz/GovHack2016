"use strict";
///<reference path="./../typings/browser/ambient/es6-shim/index.d.ts"/>
var platform_browser_dynamic_1 = require('@angular/platform-browser-dynamic');
var app_component_1 = require('./app.component');
var http_1 = require('@angular/http');
var app_routes_1 = require('./app.routes');
var api_service_1 = require('./common/api.service');
var service_safety_1 = require('./safety/service.safety');
var app_constants_1 = require('./common/app.constants');
platform_browser_dynamic_1.bootstrap(app_component_1.AppComponent, [
    app_routes_1.appRouterProviders,
    http_1.HTTP_PROVIDERS,
    http_1.Http,
    http_1.ConnectionBackend,
    app_constants_1.Configuration,
    api_service_1.ApiService,
    service_safety_1.SafetyService
])
    .catch(function (err) { return console.error(err); });
//# sourceMappingURL=main.js.map
"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
///<reference path="./../typings/browser/ambient/es6-shim/index.d.ts"/>
var core_1 = require('@angular/core');
var common_1 = require('@angular/common');
var router_1 = require('@angular/router');
require('rxjs/Rx');
var home_component_1 = require('./home.component');
var page2_component_1 = require('./page2.component');
var AppComponent = (function () {
    //headerUrl: string;
    //footerUrl: string;
    function AppComponent() {
        //this.headerUrl = "https://www.dit.ami.ldstatdv.net/partial/component/navigation";
        //this.footerUrl = "https://www.dit.ami.ldstatdv.net/partial/component/footer";
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            directives: [common_1.NgSwitch, common_1.NgSwitchDefault, home_component_1.HomeComponent, page2_component_1.Page2Component, router_1.ROUTER_DIRECTIVES],
            templateUrl: '/app/app.html'
        }), 
        __metadata('design:paramtypes', [])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map
﻿///<reference path="./../typings/browser/ambient/es6-shim/index.d.ts"/>
import {Component} from '@angular/core';
import {NgSwitch, NgSwitchDefault, Control, Validators} from '@angular/common';
import { disableDeprecatedForms, provideForms } from '@angular/forms';
import { ROUTER_DIRECTIVES } from '@angular/router';
import 'rxjs/Rx';

import { HomeComponent } from './home.component';
import { AboutComponent } from './about.component';

@Component({
    selector: 'my-app',
    directives: [NgSwitch, NgSwitchDefault, HomeComponent, AboutComponent, ROUTER_DIRECTIVES],
    templateUrl: '/app/app.html'
})
export class AppComponent {
    //headerUrl: string;
    //footerUrl: string;

    constructor() {
        //this.headerUrl = "https://www.dit.ami.ldstatdv.net/partial/component/navigation";
        //this.footerUrl = "https://www.dit.ami.ldstatdv.net/partial/component/footer";
    }
}
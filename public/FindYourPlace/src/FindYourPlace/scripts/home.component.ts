import {Component} from '@angular/core';
import {NgSwitch, NgSwitchDefault, Control, Validators} from '@angular/common';
import { disableDeprecatedForms, provideForms } from '@angular/forms';
import { ROUTER_DIRECTIVES } from '@angular/router';
import 'rxjs/Rx';

@Component({
    selector: 'home',
    directives: [],
    templateUrl: '/app/home.html'
})
export class HomeComponent {

    constructor() {

    }
}
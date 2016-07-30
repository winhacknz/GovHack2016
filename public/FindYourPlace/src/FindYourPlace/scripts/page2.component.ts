import {Component} from '@angular/core';
import {NgSwitch, NgSwitchDefault, Control, Validators} from '@angular/common';
import { disableDeprecatedForms, provideForms } from '@angular/forms';
import { ROUTER_DIRECTIVES } from '@angular/router';
import 'rxjs/Rx';

@Component({
    selector: 'page2',
    directives: [],
    templateUrl: '/app/page2.html'
})
export class Page2Component {

    constructor() {

    }
}
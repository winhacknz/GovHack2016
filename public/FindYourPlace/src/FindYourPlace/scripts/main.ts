///<reference path="./../typings/browser/ambient/es6-shim/index.d.ts"/>
import {bootstrap}    from '@angular/platform-browser-dynamic';
import {AppComponent} from './app.component';
import { HTTP_PROVIDERS } from '@angular/http';
import {disableDeprecatedForms, provideForms} from '@angular/forms';
import { appRouterProviders } from './app.routes';

bootstrap(AppComponent, [
    appRouterProviders
])
    .catch(err => console.error(err));
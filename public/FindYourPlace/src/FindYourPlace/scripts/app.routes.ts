import { provideRouter, RouterConfig } from '@angular/router';
import { HomeComponent } from './home.component';
import { Page2Component } from './page2.component';

const routes: RouterConfig = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'page2', component: Page2Component }
];

export const appRouterProviders = [
    provideRouter(routes)
];

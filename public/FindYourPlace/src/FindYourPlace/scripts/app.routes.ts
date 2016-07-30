import { provideRouter, RouterConfig } from '@angular/router';
import { HomeComponent } from './home.component';
import { AboutComponent } from './about.component';
import { SafetyComponent } from './safety/safety.component';

const routes: RouterConfig = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'about', component: AboutComponent }
    
    // write it this way simply easier to remove. Team should decide coding conventions.   ,
    ,
    { path: 'safety', component: SafetyComponent }
];

export const appRouterProviders = [
    provideRouter(routes)
];

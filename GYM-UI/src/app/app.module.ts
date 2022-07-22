import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{ Navbar } from './components/navbar/navbar.component';
import{ Footer } from './components/footer/footer.component';
import{ Section } from './components/section/section.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { Login } from './components/Login/Login.components';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    Navbar,
    Footer,
    Section,
    Pricing,
    HomeComponent,
    Login
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'pricing', component: Pricing },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

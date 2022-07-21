import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{ Navbar } from './components/navbar/navbar.component';
import{ Footer } from './components/footer/footer.component';
import{ Section } from './components/section/section.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { LoginComponent } from './components/login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    Navbar,
    Footer,
    Section,
    Pricing,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{ Navbar } from './components/navbar/navbar.component';
import{ Footer } from './components/footer/footer.component';
import{ Section } from './components/section/section.component';

@NgModule({
  declarations: [
    AppComponent,
    Navbar,
    Footer,
    Section
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

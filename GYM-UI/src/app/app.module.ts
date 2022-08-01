import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{ Navbar } from './components/navbar/navbar.component';
import{ Footer } from './components/footer/footer.component';
import{ Section } from './components/section/section.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { Login } from './components/Login/login.component';
import { About } from './components/About/about.component';
import { RegisterComponent } from './components/register/register.component';
import { AdminViewComponent } from './components/admin/admin-view.component';
import { StudentViewComponent } from './components/student-view/student-view.component';


@NgModule({
  declarations: [
    AppComponent,
    Navbar,
    Footer,
    Section,
    Pricing,
    HomeComponent,
    Login,
    About,
    RegisterComponent,
    AdminViewComponent,
    StudentViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'pricing', component: Pricing },
      {path: 'login', component: Login},
      {path: 'about', component: About},
      {path: 'register', component: RegisterComponent},
      {path: 'admin', component: AdminViewComponent},
      {path: 'student', component: StudentViewComponent},
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

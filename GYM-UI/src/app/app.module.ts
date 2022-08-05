import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Navbar } from './components/navbar/navbar.component';
import { Footer } from './components/footer/footer.component';
import { Section } from './components/section/section.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { Login } from './components/Login/login.component';
import { About } from './components/About/about.component';
import { RegisterComponent } from './components/register/register.component';
import { AdminViewComponent } from './components/admin/admin-view.component';
import { StudentViewComponent } from './components/student-view/student-view.component';
import { ClassesComponent } from './components/classes/classes.component';
import { ListaStudentComponent } from './components/admin/lista-student/lista-student.component';
import { ListaStudentClassComponent } from './components/admin/lista-student-class/lista-student-class.component';
import { ClassComponent } from './components/admin/class/class.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { ActivitiesComponent } from './activities/activities.component';
import { ActivityComponent } from './activity/activity.component';
import { NavbarAdminComponent } from './components/admin/navbar-admin/navbar-admin.component';




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
    StudentViewComponent,
    ClassesComponent,
    ListaStudentComponent,
    ListaStudentClassComponent,
    ClassComponent,
    ActivitiesComponent,
    ActivityComponent,
    NavbarAdminComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: 'pricing', component: Pricing },
      { path: 'login', component: Login },
      { path: 'about', component: About },
      { path: 'register', component: RegisterComponent },
      { path: 'admin', component: AdminViewComponent },
      { path: 'student', component: StudentViewComponent },
      { path: 'classes', component: ClassesComponent },
    ])
  ],
  providers: [],
  bootstrap: [ AppComponent ]
})
export class AppModule { }

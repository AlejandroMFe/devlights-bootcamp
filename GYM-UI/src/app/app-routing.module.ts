import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { About } from './components/About/about.component';
import { Login } from './components/Login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { ClassesComponent } from './components/classes/classes.component';
import { ListaStudentComponent } from './components/admin/lista-student/lista-student.component';
import { ListaStudentClassComponent } from './components/admin/lista-student-class/lista-student-class.component';
import {ClassComponent} from './components/admin/class/class.component';
import {NavbaradminComponent} from './components/admin/navbaradmin/navbaradmin.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'about',
    component: About
  },
  {
    path: 'post/:variable',
    component: Pricing 
  },
  {
    path: 'login',
    component: Login
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: 'classes',
    component: ClassesComponent
  },
  {
    path: 'lista-student',
    component: ListaStudentComponent
  },
  {
    path: 'lista-student-class',
    component: ListaStudentClassComponent
  },
  {
    path: 'lista-class',
    component: ClassComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

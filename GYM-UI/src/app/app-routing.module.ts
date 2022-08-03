import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { Pricing } from './components/Pricing/Pricing.component';
import { About } from './components/About/about.component';
import { Login } from './components/Login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { ClassesComponent } from './components/classes/classes.component';


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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

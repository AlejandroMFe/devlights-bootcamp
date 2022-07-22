import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { Pricing } from './components/Pricing/Pricing.component';
import{Login} from './components/Login/Login.components';


export const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'post/:variable',
    component: Pricing 
  },
  {
    path: 'post/:variable',
    component: Login
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

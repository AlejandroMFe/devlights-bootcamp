import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Pricing } from './components/Pricing/Pricing.component';


const routes: Routes = [

  { path: 'pricing', component: Pricing },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

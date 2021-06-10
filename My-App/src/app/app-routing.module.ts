import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CatalogComponent } from './catalog/catalog.component';
import { EspeciallyForYouComponent } from './especially-for-you/especially-for-you.component';

import { QuestionsReturnsComponent } from './questions-returns/questions-returns.component';
 

const routes: Routes = [
{ path:'',component:CatalogComponent},
{ path:'mycatalog',component:CatalogComponent},
{ path:'myespecially_for_you',component:EspeciallyForYouComponent},
{ path:'myquestions_returns',component:QuestionsReturnsComponent},


];
 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

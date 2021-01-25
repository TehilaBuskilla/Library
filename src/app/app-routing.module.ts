import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CatalogComponent } from './catalog/catalog.component';
import { EspeciallyForYouComponent } from './especially-for-you/especially-for-you.component';
import { InformationComponent } from './information/information.component';
import { NewestComponent } from './newest/newest.component';
 

const routes: Routes = [
{ path:'mycatalog',component:CatalogComponent},
{ path:'mynewest',component:NewestComponent},
{ path:'myespecially_for_you',component:EspeciallyForYouComponent},
{path:'myinformation',component:InformationComponent},
];
 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

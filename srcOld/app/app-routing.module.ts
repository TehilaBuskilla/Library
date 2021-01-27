import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CatalogComponent } from './catalog/catalog.component';
import { LoginComponent } from './login/login.component';
 

const routes: Routes = [
{ path:'mylogin',component:LoginComponent},
{ path:'mycatalog',component:CatalogComponent},
];
 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

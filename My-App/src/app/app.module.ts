import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CatalogComponent } from './catalog/catalog.component';
import { EspeciallyForYouComponent } from './especially-for-you/especially-for-you.component';
import { NewestComponent } from './newest/newest.component';
import { QuestionsReturnsComponent } from './questions-returns/questions-returns.component';




@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    EspeciallyForYouComponent,
    NewestComponent,
    QuestionsReturnsComponent,
    
    
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CatalogComponent } from './catalog/catalog.component';
import { EspeciallyForYouComponent } from './especially-for-you/especially-for-you.component';
import { QuestionsReturnsComponent } from './questions-returns/questions-returns.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { KindsOfBooksService } from './services/kinds-of-books.service';

import { AudiencesService } from './services/audiences.service';

import { AuthorsService } from './services/authors.service';
import { BorrowedBooksService } from './services/borrowed-books.service';
import { GendersService } from './services/genders.service';

import { ProfileBookService } from './services/profile-book.service';
import { ReadingBooksService } from './services/reading-books.service';
import { StatusUserService } from './services/status-user.service';
import { UsersService } from './services/users.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HebrewBooleanPipe } from './pipes/hebrew.boolean.pipe';
import { FilterbooklistPipe } from './pipes/filterbooklist.pipe';
import { SigninmessageComponent } from './signinmessage/signinmessage.component';




@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    EspeciallyForYouComponent,
   
    QuestionsReturnsComponent,
    HebrewBooleanPipe,
    FilterbooklistPipe,
    SigninmessageComponent,
    
    
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ KindsOfBooksService,
    AudiencesService,
    AuthorsService,
    BorrowedBooksService,
    GendersService,
    ProfileBookService,
    ReadingBooksService,
    StatusUserService,
    UsersService],
  bootstrap: [AppComponent]
})
export class AppModule { }

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

import { FilterbooklistPipe } from './pipes/filterbooklist.pipe';
import { SigninmessageComponent } from './signinmessage/signinmessage.component';
import { HistoryComponent } from './history/history.component';
import { BookToUserService } from './services/bookToUser.service';




@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    EspeciallyForYouComponent,
    QuestionsReturnsComponent,
    
    FilterbooklistPipe,
    SigninmessageComponent,
    HistoryComponent,
    
    
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
    BookToUserService,
    UsersService],
  bootstrap: [AppComponent]
})
export class AppModule { }

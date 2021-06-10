import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CatalogComponent } from './catalog/catalog.component';
import { EspeciallyForYouComponent } from './especially-for-you/especially-for-you.component';
import { QuestionsReturnsComponent } from './questions-returns/questions-returns.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { KindsOfBooksService } from './services/kinds-of-books.service';
import { AudiencesForUsersService } from './services/audiences-for-users.service';
import { AudiencesService } from './services/audiences.service';
import { AuthorsForUsersService } from './services/authors-for-users.service';
import { AuthorsService } from './services/authors.service';
import { BorrowedBooksService } from './services/borrowed-books.service';
import { GendersService } from './services/genders.service';
import { KindsOfBooksForUsersService } from './services/kinds-of-books-for-users.service';
import { ProfileBookService } from './services/profile-book.service';
import { ReadingBooksService } from './services/reading-books.service';
import { StatusUserService } from './services/status-user.service';
import { UsersService } from './services/users.service';
import { FormsModule } from '@angular/forms';
import { HebrewBooleanPipe } from './pipes/hebrew.boolean.pipe';
import { FilterbooklistPipe } from './pipes/filterbooklist.pipe';




@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    EspeciallyForYouComponent,
   
    QuestionsReturnsComponent,
    HebrewBooleanPipe,
    FilterbooklistPipe,
    
    
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    
  ],
  providers: [ KindsOfBooksService,
    AudiencesForUsersService,
    AudiencesService,
    AuthorsForUsersService,
    AuthorsService,
    BorrowedBooksService,
    GendersService,
    KindsOfBooksForUsersService,
    ProfileBookService,
    ReadingBooksService,
    AuthorsForUsersService,
    StatusUserService,
    UsersService],
  bootstrap: [AppComponent]
})
export class AppModule { }

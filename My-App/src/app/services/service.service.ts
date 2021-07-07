import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ReadingBooks } from '../class/readingBooks';
import { Observable } from 'rxjs';
import { Users } from '../class/users';
import { BookToUser } from '../class/bookToUser';
import { WishList } from '../class/wishList';
import { WishListService } from './wishList.service';
import { BookToUserService } from './bookToUser.service';
import { ReadingBooksService } from './reading-books.service';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  url = "http://localhost:65319/api/ReadingBooks/";


  constructor(private myhttp: HttpClient, private myrouter: Router,
    private wishListSer: WishListService,
    private bookToUserSer: BookToUserService,
    private readingBooksSer: ReadingBooksService) { }
  private userIn: Users;
  likebookList: Array<number> = new Array<number>();
  listBookToUser: Map<string, Map<number, number>> = new Map();
  listReadingBook: Array<ReadingBooks> = new Array<ReadingBooks>();
  loginevent = new EventEmitter<boolean>()


  BookToUser(selectedBookId: number, UserId: any, Like: boolean) {    
    let bookToUserItem = new BookToUser(0, selectedBookId, UserId, Like, new Date(), 1);//create new book into table "BookToUser"
    return this.bookToUserSer.Post(bookToUserItem);
  }


  calc() {   
    let id;
    this.readingBooksSer.GetAll().subscribe(x => { this.listReadingBook = x });//get all books from dataBase
    this.bookToUserSer.GetById(this.currentUser.IdUser).subscribe(x => { this.listBookToUser = x });//
    if (this.listBookToUser == undefined)
      this.listReadingBook = [];
    else {
      this.listReadingBook = this.listReadingBook.filter(r => this.listBookToUser["Author"].hasOwnProperty(r.Author.CodeAuthor) &&
        this.listBookToUser["Audience"].hasOwnProperty(r.Audience.CodeAudience) &&
        this.listBookToUser["KindOfBook"].hasOwnProperty(r.KindOfBook.CodeKindBook) && //filter the books that parameter is in map
        this.listBookToUser["StatusUser"].hasOwnProperty(r.StatusUser.CodeStatus) &&
        this.listBookToUser["Gender"].hasOwnProperty(r.Gender.CodeGender));
      this.listReadingBook.forEach(readingBook => {
        for (let prop in readingBook) {  //for on every book and check:
          if (typeof (readingBook[prop]) == 'object') { //if this filtering parameter     
            for (let item in readingBook[prop]) {
              id = readingBook[prop][item];
              break
            }
            if (this.listBookToUser[prop][id] > 0) //check if exist in listBookToUser this parameter with code of this parameter
              this.listBookToUser[prop][id]--; //leave this book and remove from percents this add
            else
              this.listReadingBook = this.listReadingBook.filter(d => d != readingBook);//remove this book
          }
        }
      });
     
    }

  }


  Post(map: Map<string, Map<number, number>>, userIn: Users) {
    return this.myhttp.post<number>(this.url + "Post", map);
  }

  logOut() {
    this.userIn = undefined;
    this.loginevent.emit(false)
  }

  get isLogIn() {
    return this.userIn != undefined
  }
  get currentUser() {
    return this.userIn;
  }
  SignUp(u: Users) {
    this.userIn = u;
    this.loginevent.emit(true)
  }

}
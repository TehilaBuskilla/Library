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
  bookToUserList: Array<BookToUser> = new Array<BookToUser>();
  listReadingBook: Array<ReadingBooks> = new Array<ReadingBooks>();

  loginevent = new EventEmitter<boolean>()
  BookToUser(item: ReadingBooks) {  //דחיפה של ספרים שפתח
    this.bookToUserList.push(new BookToUser(0, item.CodeBook, this.userIn.IdUser, true, new Date(), 1))

  }
  like(item: ReadingBooks) { //דחיפה של ספרים שאהב לספרים שאהב ולספרים שפתח
    this.wishListSer.Post(new WishList(0,item.CodeBook, this.userIn.IdUser));
    this.bookToUserList.push(new BookToUser(0, item.CodeBook, this.userIn.IdUser, true, new Date(), 1));

  }
  sendList() { 
    this.bookToUserSer.Post(this.bookToUserList);
  }

  calc() {
    let id;
    this.readingBooksSer.GetAll().subscribe(x => {this.listReadingBook = x});
    this.bookToUserSer.GetById(this.currentUser.IdUser).subscribe(x => {this.listBookToUser = x});
    if(this.listBookToUser==undefined)
    this.listReadingBook=[];
    else{
         this.listReadingBook=this.listReadingBook.filter(r => this.listBookToUser["Author"].hasOwnProperty(r.Author.CodeAuthor) &&
      this.listBookToUser["Audience"].hasOwnProperty(r.Audience.CodeAudience) &&
      this.listBookToUser["KindOfBook"].hasOwnProperty(r.KindOfBook.CodeKindBook) &&
      this.listBookToUser["StatusUser"].hasOwnProperty(r.StatusUser.CodeStatus) &&
      this.listBookToUser["Gender"].hasOwnProperty(r.Gender.CodeGender));
    this.listReadingBook.forEach(readingBook => {
      for (let prop in readingBook) {  //מעבר על ספר
        if (typeof (readingBook[prop]) == 'object') { //אם מדובר בפרמטר לסינון     
         for (let item in readingBook[prop]) {
               id=readingBook[prop][item];
           break
         }
          if (this.listBookToUser[prop][id] > 0) //בדוק אם קיים פרמטקר כזה עם קוד של פרמטר זה
            this.listBookToUser[prop][id]--; //אם כן השאר את הספר והורד מתוך האחוזים את ההוספה הזו
          else
          this.listReadingBook=this.listReadingBook.filter(d => d != readingBook);//להסיר ספר זה
        }
      }
    });
    console.log(this.listReadingBook)
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
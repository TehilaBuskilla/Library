import { Component, OnInit } from '@angular/core';
import { BookToUser } from '../class/bookToUser';
import { ReadingBooks } from '../class/readingBooks';
import { BookToUserService } from '../services/bookToUser.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-especially-for-you',
  templateUrl: './especially-for-you.component.html',
  styleUrls: ['./especially-for-you.component.css']
})
export class EspeciallyForYouComponent implements OnInit {
  isRegistered = false
  currentUser
  constructor(
    private BookToUserSer: BookToUserService,
    private serviceSer: ServiceService,
    private readingBookSer:ReadingBooksService
  ) { }
  bookToUserList: Array<BookToUser> = new Array<BookToUser>();
  readingBookList:Array<ReadingBooks>=new Array<ReadingBooks>();


  ngOnInit(): void {
    this.isRegistered = this.serviceSer.isLogIn;
    if(this.isRegistered){
      this.currentUser= this.serviceSer.currentUser
    }
    this.serviceSer.loginevent.subscribe(val => {this.isRegistered = val
      this.currentUser = this.serviceSer.currentUser
    })
   this.readingBookList=this.serviceSer.listReadingBook;
 
  //  this.readingBookSer.GetAll().subscribe(x=>{this.readingBookList=x});

  

     
  }


  // delete(book:BookToUser){    //מחיקת ספר מהספרים שאהבת
  //   this.BookToUserSer.Delete(book.BookCode.CodeBook);
  // }

  borrow() {                   //העברת ספר לרשימת ספרים מושאלים 

  }

}

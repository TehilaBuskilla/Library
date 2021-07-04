import { Component, OnInit } from '@angular/core';
import { BookToUser } from '../class/bookToUser';
import { ReadingBooks } from '../class/readingBooks';
import { WishList } from '../class/wishList';
import { BookToUserService } from '../services/bookToUser.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';
import { WishListService } from '../services/wishList.service';

@Component({
  selector: 'app-especially-for-you',
  templateUrl: './especially-for-you.component.html',
  styleUrls: ['./especially-for-you.component.css']
})
export class EspeciallyForYouComponent implements OnInit {
  isRegistered = false
  currentUser
  constructor(
    private bookToUserSer:BookToUserService,
    private serviceSer: ServiceService,
    private readingBookSer:ReadingBooksService,
    private wishListSer:WishListService
  ) { }
  listBookToUser:Array<BookToUser>=new Array<BookToUser>();
  listWishList: Array<WishList> = new Array<WishList>();
  readingBookList:Array<ReadingBooks>=new Array<ReadingBooks>();//all the books
  readingBook:Array<ReadingBooks>=new Array<ReadingBooks>();//for you


  ngOnInit(): void {
    this.serviceSer.calc();
    this.readingBookList=this.serviceSer.listReadingBook;
    this.readingBookSer.GetAll().subscribe(x=> this.readingBookList=x);
    this.isRegistered = this.serviceSer.isLogIn;
    if(this.isRegistered){
      this.currentUser= this.serviceSer.currentUser
    }
    this.serviceSer.loginevent.subscribe(val => {this.isRegistered = val
      this.currentUser = this.serviceSer.currentUser
    })
    
 
  this.wishListSer.GetById(this.serviceSer.currentUser.IdUser).subscribe(x=>{ this.listWishList=x});
  this.listWishList.filter(x=> x.UserId==this.serviceSer.currentUser.IdUser)
   this.listWishList.forEach(x=> 
    this.readingBookList.push(this.readingBookList.find(y=> y.CodeBook==x.BookCode))
    )     
  }


  // delete(book:BookToUser){    //מחיקת ספר מהספרים שאהבת
  //   this.BookToUserSer.Delete(book.BookCode.CodeBook);
  // }

  borrow() {                   //העברת ספר לרשימת ספרים מושאלים 

  }

}

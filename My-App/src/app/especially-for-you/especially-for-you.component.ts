import { Component, OnInit } from '@angular/core';
import { BookToUser } from '../class/bookToUser';
import { BorrowedBooks } from '../class/borrowedBooks';
import { ReadingBooks } from '../class/readingBooks';
import { WishList } from '../class/wishList';
import { BookToUserService } from '../services/bookToUser.service';
import { BorrowedBooksService } from '../services/borrowed-books.service';
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
    private bookToUserSer: BookToUserService,
    private serviceSer: ServiceService,
    private readingBookSer: ReadingBooksService,
    private borrowedBookSer:BorrowedBooksService

  ) { }
  RaedingBooksList: Array<ReadingBooks> = new Array<ReadingBooks>(); //book love
  listBookToUser: Array<BookToUser> = new Array<BookToUser>();
  listRaedingBooks: Array<ReadingBooks> = new Array<ReadingBooks>();//book for you

  ngOnInit(): void {
    this.serviceSer.calc();
    if (this.serviceSer.listBookToUser == undefined)
      this.RaedingBooksList = null
    else
      this.RaedingBooksList == this.serviceSer.listReadingBook;

    this.bookToUserSer.GetBookToUserById(this.serviceSer.currentUser.IdUser, true).subscribe(x => this.RaedingBooksList = x)
    this.bookToUserSer.GetBookToUserById(this.serviceSer.currentUser.IdUser, false).subscribe(x => this.listRaedingBooks = x)

    this.isRegistered = this.serviceSer.isLogIn;
    if (this.isRegistered) {
      this.currentUser = this.serviceSer.currentUser
    }
    this.serviceSer.loginevent.subscribe(val => {
      this.isRegistered = val
      this.currentUser = this.serviceSer.currentUser
    })

  }

  like(id) {  //like book to bookToUser
    this.serviceSer.BookToUser(id, this.serviceSer.currentUser.IdUser, true).subscribe()

  }
  borrow(borroedBook:BorrowedBooks) {                   //book to borroedBooks 
this.borrowedBookSer.Post(borroedBook);

  }

}

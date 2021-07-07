import { Component, OnInit } from '@angular/core';
import { BookToUser } from '../class/bookToUser';
import { ReadingBooks } from '../class/readingBooks';
import { BookToUserService } from '../services/bookToUser.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent implements OnInit {
  isRegistered = false
  currentUser
  listReadingBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
  listBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
  selectedBook: ReadingBooks


  constructor(public serviceSer: ServiceService,
    public bookToUserSer: BookToUserService,
    private readingBookSer: ReadingBooksService) { }

  ngOnInit(): void {
    
    this.bookToUserSer.GetBookToUserById(this.serviceSer.currentUser.IdUser).subscribe(x => this.listReadingBooks = x)

    this.isRegistered = this.serviceSer.isLogIn;
    if (this.isRegistered) {
      this.currentUser = this.serviceSer.currentUser
    }
    this.serviceSer.loginevent.subscribe(val => {
      this.isRegistered = val
      this.currentUser = this.serviceSer.currentUser
    })

  }
  bookToUser(id) {
    this.serviceSer.BookToUser(id, this.serviceSer.currentUser.IdUser, false).subscribe() //send to bookToUser
  }


}

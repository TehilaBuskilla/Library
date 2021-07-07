import { Component, OnInit } from '@angular/core';
import { element } from 'protractor';
import { BorrowedBooks } from '../class/borrowedBooks';
import { ReadingBooks } from '../class/readingBooks';
import { BorrowedBooksService } from '../services/borrowed-books.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-questions-returns',
  templateUrl: './questions-returns.component.html',
  styleUrls: ['./questions-returns.component.css']
})
export class QuestionsReturnsComponent implements OnInit {
  isRegistered = false
  currentUser

  constructor(public serviseSer: ServiceService,
    private borrowedBooksSer: BorrowedBooksService,
    private readingBooksSer: ReadingBooksService) { }
  listBorrowedBooks: Array<BorrowedBooks> = new Array<BorrowedBooks>();
  listReadingBook: Array<ReadingBooks> = new Array<ReadingBooks>();

  ngOnInit(): void {
    // this.readingBooksSer.GetAll().subscribe(x => { this.listReadingBook = x });
  //   if(for(x=>x.UserId==this.currentUser)){
  this.borrowedBooksSer.GetBy(this.currentUser.UserId).subscribe(x =>{ this.listBorrowedBooks = x });
  
  //  this.listReadingBook.forEach(e=>
  //     this.listBorrowedBooks.find(x=>x.BookCode==e.CodeBook));
    this.isRegistered = this.serviseSer.isLogIn;
    if (this.isRegistered) {
      this.currentUser = this.serviseSer.currentUser
      
    }
    this.serviseSer.loginevent.subscribe(val => {
      this.isRegistered = val
      this.currentUser = this.serviseSer.currentUser
    })
    
  }

}

import { Component, OnInit } from '@angular/core';
import { BorrowedBooks } from '../class/borrowedBooks';
import { BorrowedBooksService } from '../services/borrowed-books.service';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-questions-returns',
  templateUrl: './questions-returns.component.html',
  styleUrls: ['./questions-returns.component.css']
})
export class QuestionsReturnsComponent implements OnInit {
  isRegistered = false
  currentUser

  constructor(public serviseSer:ServiceService,
    private borrowedBooksSer:BorrowedBooksService ) { }
  listBorrowedBooks: Array<BorrowedBooks> = new Array<BorrowedBooks>();

  ngOnInit(): void {
    this.borrowedBooksSer.GetAll().subscribe(x=>{this.listBorrowedBooks=x});
    this.isRegistered=this.serviseSer.isLogIn;
    if(this.isRegistered){
      this.currentUser=this.serviseSer.currentUser
    }
    this.serviseSer.loginevent.subscribe(val=>{this.isRegistered=val
    this.currentUser=this.serviseSer.currentUser})
  }

}

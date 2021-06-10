import { Component, OnInit } from '@angular/core';
import { BookToUser } from '../class/bookToUser';
import { BookToUserService } from '../services/bookToUser.service';

@Component({
  selector: 'app-especially-for-you',
  templateUrl: './especially-for-you.component.html',
  styleUrls: ['./especially-for-you.component.css']
})
export class EspeciallyForYouComponent implements OnInit {

  constructor(
    private BookToUserSer:BookToUserService,
  ) { }
bookToUserList:Array<BookToUser>=new Array<BookToUser>();
  ngOnInit(): void {
this.BookToUserSer.GetAll().subscribe(x=>{this.bookToUserList=x});
  }


  // delete(book:BookToUser){    //מחיקת ספר מהספרים שאהבת
  //   this.BookToUserSer.Delete(book.BookCode.CodeBook);
  // }

  borrow(){                   //העברת ספר לרשימת ספרים מושאלים 

  }

}

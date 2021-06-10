import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ReadingBooks } from '../class/readingBooks';
import { Observable } from 'rxjs';
import { Users } from '../class/users';
import { BookToUser } from '../class/bookToUser';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  url="http://localhost:65319/api/ReadingBooks/";


  constructor(private myhttp:HttpClient,private myrouter: Router) { }
  userIn:Users=new Users();
  likebookList: Array<number> = new Array<number>();
  BookToUserList: Array<BookToUser> = new Array<BookToUser>();

  BookToUser(item: ReadingBooks){  //דחיפה של ספרים שפתח
    this.BookToUserList.push(new BookToUser(0,item.CodeBook,this.userIn.IdUser,true,new Date(),1))

  }
  like(item){ //דחיפה של ספרים שאהב לספרים שאהב ולספרים שפתח

    this.likebookList.push(item.CodeBook);
    this.BookToUserList.push(new BookToUser(0,item.CodeBook,this.userIn.IdUser,true,new Date(),1))

  }

  sendList(){

  }
  Post(map:Map<string, Map<number, number>>,userIn:Users)
  {
    return this.myhttp.post<number>(this.url+"Post",map);
  }



  
}
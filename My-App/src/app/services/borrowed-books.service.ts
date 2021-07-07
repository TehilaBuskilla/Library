import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { BorrowedBooks } from '../class/borrowedBooks';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BorrowedBooksService {
  url="http://localhost:65319/api/BorrowedBooks/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<BorrowedBooks[]>
  {
    return this.myhttp.get<BorrowedBooks[]>(this.url+"GetAll");
  }
  GetBy(code:string):Observable<BorrowedBooks[]>
  {
    return this.myhttp.get<BorrowedBooks[]>(this.url+"GetBy/"+code);
  }


  Post(newBorrowedBook:BorrowedBooks):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post/",newBorrowedBook);
  }

  Put(upBorrowedBook:BorrowedBooks):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upBorrowedBook);
  }
  
  Delete(CodeBorrowedBooks:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeBorrowedBooks);
  }
}

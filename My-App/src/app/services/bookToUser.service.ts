import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

import { Observable } from 'rxjs';
import { BookToUser } from '../class/bookToUser';

@Injectable({
  providedIn: 'root'
})
export class BookToUserService
{
    url="http://localhost:65319/api/BookToUser/";

    constructor(private myhttp:HttpClient,private myrouter: Router) { }
  
  
    GetAll():Observable<BookToUser[]>
    {
      return this.myhttp.get<BookToUser[]>(this.url+"GetAll");
    }

  Post(newBookToUser:BookToUser):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newBookToUser);
  }

  Put(upBookToUser:BookToUser):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upBookToUser);
  }
  
  Delete(CodeBookToUser:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeBookToUser);
  }
}

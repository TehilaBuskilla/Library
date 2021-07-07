import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

import { Observable } from 'rxjs';
import { BookToUser } from '../class/bookToUser';
import { ReadingBooks } from '../class/readingBooks';

@Injectable({
  providedIn: 'root'
})
export class BookToUserService
{
    url="http://localhost:65319/api/BookToUser/";

    constructor(private myhttp:HttpClient,private myrouter: Router) { }
  
   GetById(id:string):Observable<Map<string,Map<number,number>>>
    {
      return this.myhttp.get<Map<string,Map<number,number>>>(this.url+"GetById/"+id);
    }
    GetBookToUserById(id:string,love:boolean=false):Observable<ReadingBooks[]>
  {
    return this.myhttp.get<ReadingBooks[]>(this.url+"GetAll/"+id+"/"+love);
  }
    GetAll():Observable<Array<BookToUser>>
    {
      return this.myhttp.get<Array<BookToUser>>(this.url+"GetAll");
    }   

  Post(newBookToUser: BookToUser):Observable<number>
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

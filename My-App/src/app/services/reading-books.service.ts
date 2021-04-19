import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ReadingBooks } from '../class/readingBooks';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ReadingBooksService {
  url="http://localhost:65319/api/ReadingBooks/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<ReadingBooks[]>
  {
    return this.myhttp.get<ReadingBooks[]>(this.url+"GetAll");
  }

  GetBottom10():Observable<ReadingBooks[]>    
  {
    return this.myhttp.get<ReadingBooks[]> (this.url+"GetBottom10");
  }

  Post(newReadingBook:ReadingBooks):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newReadingBook);
  }

  Put(upReadingBook:ReadingBooks):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upReadingBook);
  }

  Delete(CodeReadingBook:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeReadingBook);
  }
}

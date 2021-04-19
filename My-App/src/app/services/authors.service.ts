import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Authors } from '../class/authors';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorsService {
  url="http://localhost:65319/api/Authors/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<Authors[]>
  {
    return this.myhttp.get<Authors[]>(this.url+"GetAll");
  }

  Post(newAuthor:Authors):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newAuthor);
  }

  Put(upAuthor:Authors):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upAuthor);
  }
  
  Delete(CodeAuthor:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeAuthor);
  }
}

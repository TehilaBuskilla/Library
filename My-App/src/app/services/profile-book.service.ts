import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ProfileBook } from '../class/profileBook';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProfileBookService {
  url="http://localhost:65319/api/ProfileBook/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<ProfileBook[]>
  {
    return this.myhttp.get<ProfileBook[]>(this.url+"GetAll");
  }

  Post(newProfileBook:ProfileBook):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newProfileBook);
  }

  Put(upProfileBook:ProfileBook):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upProfileBook);
  }

  Delete(CodeProfileBook:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeProfileBook);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { AuthorsForUsers } from '../class/authorsForUsers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorsForUsersService {
  url="http://localhost:65319/api/AuthorsForUsers/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<AuthorsForUsers[]>
  {
    return this.myhttp.get<AuthorsForUsers[]>(this.url+"GetAll");
  }

  Post(newAuthorForUser:AuthorsForUsers):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newAuthorForUser);
  }

  Put(upAuthorForUser:AuthorsForUsers):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upAuthorForUser);
  }
  
  Delete(CodeAuthorsForUsers:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeAuthorsForUsers);
  }
}

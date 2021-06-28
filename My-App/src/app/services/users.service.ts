import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Users } from '../class/users';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  url='http://localhost:65319/api/Users/';

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<Users[]>
  {
    return this.myhttp.get<Users[]>(this.url+"GetAll");
  }

  Post(newUser:Users):Observable<string>
  {
    
    return this.myhttp.post<string>(`http://localhost:65319/api/Users/Post`,newUser);
  }

  

  Put(upUser:Users):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upUser);
  }

  Delete(IdUser:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+IdUser);
  }
  //התחברות משתמש
  SignIn(existUser:Users):Observable<Users>
  {
    console.log(existUser)
    return this.myhttp.post<Users>(this.url+"Connect", existUser );
  }
}

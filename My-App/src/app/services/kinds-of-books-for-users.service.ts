import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { KindsOfBooksForUsers } from '../class/kindsOfBooksForUsers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class KindsOfBooksForUsersService {
  url="http://localhost:65319/api/KindsOfBooksForUsers/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<KindsOfBooksForUsers[]>
  {
    return this.myhttp.get<KindsOfBooksForUsers[]>(this.url+"GetAll");
  }

  Post(newKindOfBookForUser:KindsOfBooksForUsers):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newKindOfBookForUser);
  }

  Put(upKindOfBookForUser:KindsOfBooksForUsers):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upKindOfBookForUser);
  }

  Delete(CodeKindsOfBooksForUsers:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeKindsOfBooksForUsers);
  }
}

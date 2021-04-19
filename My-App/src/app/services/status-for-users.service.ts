import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { StatusForUsers } from '../class/statusForUsers';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StatusForUsersService {
  url="http://localhost:65319/api/StatusForUsers/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<StatusForUsers[]>
  {
    return this.myhttp.get<StatusForUsers[]>(this.url+"GetAll");
  }

  Post(newStatusForUser:StatusForUsers):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newStatusForUser);
  }

  Put(upStatusForUser:StatusForUsers):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upStatusForUser);
  }

  Delete(CodeStatusForUsers:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeStatusForUsers);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { StatusUser } from '../class/statusUser';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StatusUserService {
  url="http://localhost:65319/StatusUser/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<StatusUser[]>
  {
    return this.myhttp.get<StatusUser[]>(this.url+"GetAll");
  }

  Post(newStatusUser:StatusUser):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newStatusUser);
  }

  Put(upStatusUser:StatusUser):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upStatusUser);
  }

  Delete(CodeStatusUser:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeStatusUser);
  }
}

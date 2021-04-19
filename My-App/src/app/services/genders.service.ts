import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Genders } from '../class/genders';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GendersService {
  url="http://localhost:65319/api/Genders/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<Genders[]>
  {
    return this.myhttp.get<Genders[]>(this.url+"GetAll");
  }

  Post(newGender:Genders):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newGender);
  }

  Put(upGender:Genders):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upGender);
  }

  Delete(CodeGender:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeGender);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Audiences } from '../class/audiences';

@Injectable({
  providedIn: 'root'
})
export class AudiencesService {

  list = [{
    id: 5, name: 'פעוטות'
  },
  {
    id: 6, name: 'ילדים'
  }, { id: 7, name: 'נוער' }, { id: 10, name: 'מבוגרים' },{id:11, name:'ילדים ונוער'},{id:12, name:'נוער ומבוגרים'}]





  url="http://localhost:65319/api/Audiences/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<Audiences[]>
  {
    return this.myhttp.get<Audiences[]>(this.url+"GetAll");
  }

  Post(newAudience:Audiences):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newAudience);
  }

  Put(upAudience:Audiences):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upAudience);
  }
  
  Delete(CodeAudience:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeAudience);
  }
}

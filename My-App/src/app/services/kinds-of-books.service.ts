import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { KindsOfBooks } from '../class/kindsOfBooks';

@Injectable({
  providedIn: 'root'
})
export class KindsOfBooksService {
  

  url = "http://localhost:65319/api/KindsOfBooks/";

  constructor(private myhttp: HttpClient, private myrouter: Router) { }


  
  GetAll():Observable<KindsOfBooks[]>
  {
    return this.myhttp.get<KindsOfBooks[]>(this.url+"GetAll");
  }

  Post(newKindOfBook:KindsOfBooks):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newKindOfBook);
  }

  Put(upKindOfBook:KindsOfBooks):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upKindOfBook);
  }

  Delete(CodeKindsOfBooks:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeKindsOfBooks);
  }
}

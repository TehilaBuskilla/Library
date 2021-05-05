import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ReadingBooks } from '../class/readingBooks';
import { Observable } from 'rxjs';
import { Users } from '../class/users';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  url="http://localhost:65319/api/ReadingBooks/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }
  userIn:Users;
}
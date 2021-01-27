import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class KindsOfBooksForUsersService {
  url="http://localhost:54300/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }
}

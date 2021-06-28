import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { WishList } from "../class/wishList";

@Injectable({
    providedIn: 'root'
  })
  export class WishListService {
  
    
    url="http://localhost:65319/api/WishList/";
  
    constructor(private myhttp:HttpClient,private myrouter: Router) { }
  
    GetAll():Observable<WishList[]>
    {
      return this.myhttp.get<WishList[]>(this.url+"GetAll");
    }
  
    Post(newAudience:WishList):Observable<number>
    {
      return this.myhttp.post<number>(this.url+"Post",newAudience);
    }
  
    Put(upWishList:WishList):Observable<boolean>
    {
      return this.myhttp.put<boolean>(this.url+"Put",upWishList);
    }
    
    Delete(CodeWishList:number):Observable<boolean>
    {
      return this.myhttp.delete<boolean>(this.url+"Delete"+CodeWishList);
    }
  }
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { AudiencesForUsers } from '../class/audiencesForUsers';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AudiencesForUsersService {
  url="http://localhost:65319/api/AudiencesForUsers/";

  constructor(private myhttp:HttpClient,private myrouter: Router) { }

  GetAll():Observable<AudiencesForUsers[]>
  {
    return this.myhttp.get<AudiencesForUsers[]>(this.url+"GetAll");
  }
getById(id:number):Observable<AudiencesForUsers[]>
{
  return this.myhttp.get<AudiencesForUsers[]>(this.url+"getById"+id);
  
}
  Post(newAudienceForUser:AudiencesForUsers):Observable<number>
  {
    return this.myhttp.post<number>(this.url+"Post",newAudienceForUser);
  }

  Put(upAudienceForUser:AudiencesForUsers):Observable<boolean>
  {
    return this.myhttp.put<boolean>(this.url+"Put",upAudienceForUser);
  }
  
  Delete(CodeAudiencesForUsers:number):Observable<boolean>
  {
    return this.myhttp.delete<boolean>(this.url+"Delete"+CodeAudiencesForUsers);
  }
}

import { Component } from '@angular/core';
import { Genders } from './class/genders';
import { StatusUser } from './class/statusUser';
import { Users } from './class/users';
import { GendersService } from './services/genders.service';
import { ServiceService } from './services/service.service';
import { StatusUserService } from './services/status-user.service';
import { UsersService } from './services/users.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {
  constructor(private userSer:UsersService,
     private genderService:GendersService,
    private statusUserService:StatusUserService,
    public ServiceSer:ServiceService
    ){

      this.loadGenders();
      this.loadStatusUsers();

    }
  newUser:Users=new Users();
  existUser:Users=new Users();
  allGenders:Genders[]=[]
  allStatusUser:StatusUser[]=[]
  title = 'super'
  show: boolean = true;
  modalShow: boolean = false;
  showThis() {
    this.show = false;
    this.modalShow = false;
  }

  loadGenders()
  {
     this.genderService.GetAll().subscribe(res=>this.allGenders=res)
  }

  loadStatusUsers()
  {
    this.statusUserService.GetAll().subscribe(res=>this.allStatusUser=res)

  }

  showModal(flag: number) {
    console.log(flag);
    if (flag == 1)
      this.modalShow = true;
    else
      this.modalShow = false;
  }
  
  signUp(){
    console.log(JSON.stringify(this.newUser))
    this.userSer.Post(this.newUser).subscribe(
      IdUser=>{
        this.newUser.IdUser=IdUser
        if(IdUser=='0')
              console.log("בחר שם אחר שם משתמש זה כבר קיים")
        else
        console.log(IdUser,this.newUser.NameUser)
      }
    )
    this.ServiceSer.userIn=this.newUser;
  }

  signIn(){

    this.userSer.SignIn(this.newUser).subscribe(x=>this.newUser=x);
    this.ServiceSer.userIn=this.newUser;
  }

  
  
}


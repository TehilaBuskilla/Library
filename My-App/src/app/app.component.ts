import { Component } from '@angular/core';
import { Users } from './class/users';
import { UsersService } from './services/users.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {
  constructor(private userSer:UsersService){}
  user:Users=new Users();
  title = 'super'
  show: boolean = true;
  modalShow: boolean = false;
  showThis() {
    this.show = false;
    this.modalShow = false;
  }
  showModal(flag: number) {
    console.log(flag);
    if (flag == 1)
      this.modalShow = true;
    else
      this.modalShow = false;
  }
  
  signUp(){
    

     this.userSer.Post(this.user);
     
  }

  signIn(){
    this.userSer.SignIn(this.user).subscribe(x=>this.user=x);

  }
  
}


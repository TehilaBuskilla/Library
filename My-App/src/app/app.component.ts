import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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

  signInFrm: FormGroup
  constructor(private userSer: UsersService,
    private genderService: GendersService,
    private statusUserService: StatusUserService,
    public ServiceSer: ServiceService,
    private router:Router
  ) {

    this.loadGenders();
    this.loadStatusUsers();

  }

  ngOnInit() {
    if (localStorage.getItem('user')) {
      this.newUser.IdUser = localStorage.getItem('user')
      this.userSer.SignIn(this.newUser).subscribe(x => {
        console.log('x:', x)
        if (x != null) {
          this.newUser = x
          this.ServiceSer.SignUp(this.newUser); 
          this.showRegistration = false;
        }
      })
    }



    this.signInFrm = new FormGroup({
      username: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
      connected: new FormControl(true)
    })
  }
  showRegistration = true
  newUser: Users = new Users();
  existUser: Users = new Users();
  allGenders: Genders[] = []
  allStatusUser: StatusUser[] = []
  title = 'super'
  show: boolean = true;
  modalShow: boolean = false;
  showThis() {
    this.show = false;
    this.modalShow = false;
  }

  loadGenders() {
    this.genderService.GetAll().subscribe(res => this.allGenders = res)
  }

  loadStatusUsers() {
    this.statusUserService.GetAll().subscribe(res => this.allStatusUser = res)

  }

  showModal(flag: number) {
    console.log(flag);
    if (flag == 1)
      this.modalShow = true;
    else
      this.modalShow = false;
  }

  signUp() {
    console.log(JSON.stringify(this.newUser))
    this.userSer.Post(this.newUser).subscribe(
      IdUser => {
        this.newUser.IdUser = IdUser
        if (IdUser == '0')
          console.log("בחר שם אחר שם משתמש זה כבר קיים")
        else
          console.log(IdUser, this.newUser.NameUser)
      }
    )
    this.ServiceSer.SignUp(this.newUser);
  }

  exit(){
    this.showRegistration= true;
    this.ServiceSer.sendList();
    this.ServiceSer.logOut();
    localStorage.clear();
  }

  signIn() {
    this.newUser.IdUser = this.signInFrm.controls['password'].value.trim()
    this.newUser.NameUser = this.signInFrm.controls['username'].value.trim()
    let connect = this.signInFrm.controls['connected'].value
    this.userSer.SignIn(this.newUser).subscribe(x => {
      console.log('x:', x)
      if (x != null) {
        this.newUser = x
        this.ServiceSer.SignUp(this.newUser);
        this.showRegistration = false
        this.ServiceSer.calc();
        this.router.navigate(['myespecially_for_you']);
        if (connect) {

          localStorage.setItem('user', this.newUser.IdUser)
        }
        this.showModal(0)
      }
      else {
        document.querySelector('#tab-2').setAttribute('checked', 'checked')
      }
    });
  }



}


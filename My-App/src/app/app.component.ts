import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
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
}


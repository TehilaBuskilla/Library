import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'super'
  show: boolean = true;
  modalShow: boolean = true;
  showThis() {
    this.show = false;
  }
  modal(flag: number) {
    if (flag == 1)
      this.modalShow = true;
    else
      this.modalShow = false;
  }
}


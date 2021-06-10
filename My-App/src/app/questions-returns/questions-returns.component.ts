import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-questions-returns',
  templateUrl: './questions-returns.component.html',
  styleUrls: ['./questions-returns.component.css']
})
export class QuestionsReturnsComponent implements OnInit {

  constructor(public serviseSer:ServiceService) { }

  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';
import { ReadingBooks } from '../class/readingBooks';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';

@Component({
  selector: 'app-newest',
  templateUrl: './newest.component.html',
  styleUrls: ['./newest.component.css']
})
export class NewestComponent implements OnInit {

  categories =[]
  selectedcategory:any = {id:0, name:''}
  constructor(private kindOfBookService: KindsOfBooksService,private readingBookSer:ReadingBooksService) { }

  listBooksNew:Array<ReadingBooks>=new Array<ReadingBooks>();
  ngOnInit(): void {
    this.categories= this.kindOfBookService.list;
    this.readingBookSer.GetBottom10().subscribe(x=>{this.listBooksNew=x;
  });
}
}

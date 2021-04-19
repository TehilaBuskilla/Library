import { Component, OnInit } from '@angular/core';
import { ReadingBooks } from '../class/readingBooks';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  book:ReadingBooks
  
  categories =[]
  selectedcategory:any = {id:0, name:''}
  constructor(private kindOfBookSer: KindsOfBooksService,
    private readingBookSer:ReadingBooksService,
    ) { }

    listBooks:Array<ReadingBooks>=new Array<ReadingBooks>();
  ngOnInit(): void {
   this.categories= this.kindOfBookSer.list;
   this.readingBookSer.GetAll().subscribe(x=>{this.listBooks=x;

  });
  //  this.book.isBorrowed
  }

  selectitem(id){
    console.log(this.categories, id)
    
    this.selectedcategory= this.categories.find(c=>c.id===id)
    console.log(this.selectedcategory.id)
  }
  

}

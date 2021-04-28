import { Component, OnInit } from '@angular/core';
import { Audiences } from '../class/audiences';
import { ReadingBooks } from '../class/readingBooks';
import { AudiencesService } from '../services/audiences.service';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';

@Component({
  selector: 'app-newest',
  templateUrl: './newest.component.html',
  styleUrls: ['./newest.component.css']
})
export class NewestComponent implements OnInit {

  categoriesOfKind =[]
  selectedCategoryOfKind:any = {id:0, name:''}
  categoriesOfAudience=[]
  selectedCategoryOfAudience:any = {id:0, name:''}


  constructor(private kindOfBookSer: KindsOfBooksService,
    private readingBookSer:ReadingBooksService,
    private audienceSer:AudiencesService, ) { }

  listBooksNew:Array<ReadingBooks>=new Array<ReadingBooks>();
  listAudience:Array<Audiences>=new Array <Audiences>();

  ngOnInit(): void {
    this.categoriesOfKind = this.kindOfBookSer.list;
    this.readingBookSer.GetAll().subscribe(x => { this.listBooksNew  = x});
    this.categoriesOfAudience=this.audienceSer.list;
    this.audienceSer.GetAll().subscribe(x => { this.listAudience = x});
    //  this.book.isBorrowed
  }

  selectitem(id) {
    

    this.selectedCategoryOfKind = this.categoriesOfKind.find(c => c.id === id)
  }
  
  selectitem1(id){
    this.selectedCategoryOfAudience = this.categoriesOfAudience.find(c => c.id === id)

  }
}

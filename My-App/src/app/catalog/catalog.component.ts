import { Component, OnInit } from '@angular/core';
import { Audiences } from '../class/audiences';
import { AudiencesForUsers } from '../class/audiencesForUsers';
import { AuthorsForUsers } from '../class/authorsForUsers';
import { ReadingBooks } from '../class/readingBooks';
import { AudiencesForUsersService } from '../services/audiences-for-users.service';
import { AudiencesService } from '../services/audiences.service';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  book: ReadingBooks

  categoriesOfKind = []
  selectedCategoryOfKind: any = { id: 0, name: '' }
  categoriesOfAudience=[]
  selectedCategoryOfAudience: any = { id: 0, name: '' }
  listAuthorsForUsers:Array<AuthorsForUsers>=new Array<AuthorsForUsers>();
  listAudiencesForUsers:Array<AudiencesForUsers>=new Array<AudiencesForUsers>();


  constructor(private kindOfBookSer: KindsOfBooksService,
    private readingBookSer: ReadingBooksService,
    private audienceSer:AudiencesService,
  ) { }

  listBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
  listAudience:Array<Audiences>=new Array <Audiences>();

  ngOnInit(): void {
    this.categoriesOfKind = this.kindOfBookSer.list;
    this.readingBookSer.GetAll().subscribe(x => { this.listBooks = x});
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
  saveInfo(book:ReadingBooks){
  
  }


}

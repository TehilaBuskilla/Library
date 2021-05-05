import { Component, OnInit } from '@angular/core';
import { Audiences } from '../class/audiences';
import { AudiencesForUsers } from '../class/audiencesForUsers';
import { Authors } from '../class/authors';
import { AuthorsForUsers } from '../class/authorsForUsers';
import { bookToUser } from '../class/bookToUser';
import { ReadingBooks } from '../class/readingBooks';
import { AudiencesForUsersService } from '../services/audiences-for-users.service';
import { AudiencesService } from '../services/audiences.service';
import { AuthorsService } from '../services/authors.service';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';

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
  categoriesOfAuthor=[]
  selectedCategoryOfAuthor:any={id:0,name:''}
  selectedCategoryOfAudience: any = { id: 0, name: '' }
  listAuthorsForUsers:Array<AuthorsForUsers>=new Array<AuthorsForUsers>();
  listAudiencesForUsers:Array<AudiencesForUsers>=new Array<AudiencesForUsers>();

  


  constructor(private kindOfBookSer: KindsOfBooksService,
    private readingBookSer: ReadingBooksService,
    private audienceSer:AudiencesService,
    private authorSer:AuthorsService,
    private ServiceSer:ServiceService
  ) { }

  listBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
  listAudience:Array<Audiences>=new Array <Audiences>();
  listAuthor:Array<Authors>=new Array<Authors>();
  likebook:bookToUser;
  ngOnInit(): void {
    this.categoriesOfKind = this.kindOfBookSer.list;
    this.readingBookSer.GetAll().subscribe(x => { this.listBooks = x});
    this.categoriesOfAudience=this.audienceSer.list;
    this.audienceSer.GetAll().subscribe(x => { this.listAudience = x})
    this.authorSer.GetAll().subscribe(x=>{this.listAuthor=x});
    //  this.book.isBorrowed
  }
like(item:ReadingBooks){
this.likebook.idBook=item.CodeBook;
this.likebook.idUser=this.ServiceSer.userIn.IdUser;
  
  //לעשות שליחה של הספר שהוא אוהב
}
  selectitem(id) {
    

    this.selectedCategoryOfKind = this.categoriesOfKind.find(c => c.id === id)
  }
  
  selectitem1(id){
    this.selectedCategoryOfAudience = this.categoriesOfAudience.find(c => c.id === id)

  }
  selectitem2(id){
    this.selectedCategoryOfAuthor = this.categoriesOfAuthor.find(c => c.id === id)

  }
  saveInfo(book:ReadingBooks){
  
  }


}

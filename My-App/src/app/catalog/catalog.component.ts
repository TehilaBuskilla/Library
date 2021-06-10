import { newArray } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Audiences } from '../class/audiences';
import { AudiencesForUsers } from '../class/audiencesForUsers';
import { Authors } from '../class/authors';
import { AuthorsForUsers } from '../class/authorsForUsers';
import { BookToUser } from '../class/bookToUser';
import { KindsOfBooks } from '../class/kindsOfBooks';
import { ReadingBooks } from '../class/readingBooks';
import { StatusForUsers } from '../class/statusForUsers';
import { StatusUser } from '../class/statusUser';
import { Users } from '../class/users';
import { AudiencesForUsersService } from '../services/audiences-for-users.service';
import { AudiencesService } from '../services/audiences.service';
import { AuthorsService } from '../services/authors.service';
import { BookToUserService } from '../services/bookToUser.service';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';
import { StatusForUsersService } from '../services/status-for-users.service';
import {FilterBookObject} from '../class/filterobject' 


@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']

})
export class CatalogComponent implements OnInit {

  book: ReadingBooks;
  kindBook: ReadingBooks = new ReadingBooks();
  listAuthorsForUsers: Array<AuthorsForUsers> = new Array<AuthorsForUsers>();
  listAudiencesForUsers: Array<AudiencesForUsers> = new Array<AudiencesForUsers>();

  constructor(private kindOfBookSer: KindsOfBooksService,
    private readingBookSer: ReadingBooksService,
    private audienceSer: AudiencesService,
    private authorSer: AuthorsService,
    public serviceSer: ServiceService,
    private bookToUserSer: BookToUserService,
    private statusForUsersSer: StatusForUsersService,

  ) { }
  
  listMone:Map<string,Map<number,number>>=new Map();
  userIn:Users=new Users();
  listBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
 
  listAudience: Array<Audiences> = new Array<Audiences>();
  listAuthor: Array<Authors> = new Array<Authors>();
  listKindBook:Array<KindsOfBooks>=new Array<KindsOfBooks>();
  listReadingBook: Array<ReadingBooks> = new Array<ReadingBooks>();
  likebook: BookToUser = new BookToUser();
  moneStatus: Array<number> = new Array<number>(0, 0, 0);
  max = 0;
  selectedBook:ReadingBooks
  filteritem = new FilterBookObject();
  ngOnInit(): void {

    this.readingBookSer.GetAll().subscribe(x => { this.listBooks = x });
    this.audienceSer.GetAll().subscribe(x => { this.listAudience = x })
    this.authorSer.GetAll().subscribe(x => { this.listAuthor = x });
    this.readingBookSer.GetAll().subscribe(x => { this.listReadingBook = x });
    this.kindOfBookSer.GetAll().subscribe(x=>{this.listKindBook=x});
  }


  filterBooks(prop:string, val:any){
    this.filteritem[prop] = val;
   
  }

  clearFilter(){
    this.filteritem = new   FilterBookObject();
  }

  
  

  algo() {                     //אלגוריתם
      this.listMone = new Map()
      for (let item in this.listReadingBook[0]) {
        this.listMone.set(item, new Map());
      }
      this.listReadingBook.forEach(element => {
        for (let item in element) {
          let val = this.listMone.get(item)
          let innerval = 0;
          if (typeof (element[item]) == 'object') {
            for (let key in element[item]) {
              if (key.indexOf('Id') != -1) {

                innerval = val.get(element[item][key])
                if (innerval != undefined) {
                  innerval += 1;
                  
                }
                else {
                  innerval = 1;
                }
                val.set(element[item][key], innerval)
              }
            }
          }
          if(element[item]=='IdUser')
          {
            innerval = val.get(element[item])
            if (innerval != undefined) {
              innerval += 1;
            }
            else {
              innerval = 1;
            }
            val.set(element[item], innerval)
          }
        }
       
      });  
this.close();
  }
  close(){
    this.serviceSer.Post(this.listMone,this.userIn);
  }


  // info(item: ReadingBooks) {
  //   this.addMone(item.Author.CodeAuthor,this.MapAuthor);
  //   this.addMone(item.Status.CodeStatus,this.MapStatus);
  //   this.addMone(item.Audience.CodeAudience,this.MapAudience);
  //   this.addMone(item.KindOfBook.CodeKindBook,this.MapKindOfBook);
  //   // this.likebookList.push(item);
  //   // if (this.likebookList.length == 4)
  //     // this.algo();
  // }

  //אלגוריתם
  //when the widow is close
  ///
  //  MapAudience=new Map();
  //  MapAuthor = new Map();
  //  MapKindOfBook=new Map();
  //  MapStatus = new Map();

  // addMone(item: number,myMap:Map<number,number>) {
  //   if (myMap.get(item) > 0)
  //     myMap.set(item, myMap.get(item) + 1);
  //   else
  //     myMap.set(item, 1);
  // }

  ///
//   algo() {
//    // אמור לשלוח את כל המפות לקונטרולר
//     // this.likebookList.forEach(element => {
//     //   //איך אני בודקת מה משותף
//     //   this.addMone(element.Author.CodeAuthor,this.MapAuthor);
//     //   this.addMone(element.Status.CodeStatus,this.MapStatus);
//     // });
// //צריךלמצוא פונקציה יעילה שתמצא לי את הערך המקסימלי
//   Math.max(...this.moneStatus);
// }

// likebookList: Array<number> = new Array<number>();
// BookToUserList: Array<BookToUser> = new Array<BookToUser>();

  // like(item: ReadingBooks) {
  //   this.likebookList.push(item.CodeBook);
  //   this.BookToUserList.push(new BookToUser(0,item.CodeBook,this.serviceSer.userIn.IdUser))
    
  //   //לעשות שליחה של הספר שהוא אוהב
  // }
 
  saveInfo(book: ReadingBooks) {

  }


}

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

import { AudiencesService } from '../services/audiences.service';
import { AuthorsService } from '../services/authors.service';
import { BookToUserService } from '../services/bookToUser.service';
import { KindsOfBooksService } from '../services/kinds-of-books.service';
import { ReadingBooksService } from '../services/reading-books.service';
import { ServiceService } from '../services/service.service';

import { FilterBookObject } from '../class/filterobject'


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


  ) { }
  userIn: Users = new Users();
  listBooks: Array<ReadingBooks> = new Array<ReadingBooks>();
  listAudience: Array<Audiences> = new Array<Audiences>();
  listAuthor: Array<Authors> = new Array<Authors>();
  listKindBook: Array<KindsOfBooks> = new Array<KindsOfBooks>();
  listReadingBook: Array<ReadingBooks> = new Array<ReadingBooks>();
  likebook: BookToUser = new BookToUser();

  selectedBook: ReadingBooks
  filteritem = new FilterBookObject();
  ngOnInit(): void {

    this.readingBookSer.GetAll().subscribe(x => { this.listBooks = x });
    this.audienceSer.GetAll().subscribe(x => { this.listAudience = x });
    this.authorSer.GetAll().subscribe(x => { this.listAuthor = x });
    this.readingBookSer.GetAll().subscribe(x => { this.listReadingBook = x });
    this.kindOfBookSer.GetAll().subscribe(x => { this.listKindBook = x });

  }


  filterBooks(prop: string, val: any) {
    this.filteritem[prop] = val;

  }

  clearFilter() {
    this.filteritem = new FilterBookObject();
  }
  like(id) {
    this.serviceSer.BookToUser(id, this.serviceSer.currentUser.IdUser, true).subscribe()
  }
  bookToUser(id) {
    this.serviceSer.BookToUser(id, this.serviceSer.currentUser.IdUser, false).subscribe()
  }


}

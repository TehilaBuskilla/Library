
import { Pipe, PipeTransform } from '@angular/core';
import { FilterBookObject } from '../class/filterobject';
import { ReadingBooks } from '../class/readingBooks';

@Pipe({
  name: 'filterbooklist',
  pure:false 
  
})
export class FilterbooklistPipe implements PipeTransform {

  transform(value: Array<ReadingBooks>, filter: FilterBookObject): Array<ReadingBooks> {

    let list = value;
    if (filter != undefined) {
      if (filter.audience != undefined) {
        
        list = list.filter(l => l.Audience.CodeAudience == filter.audience.CodeAudience)
      }
      
      if (filter.kind != undefined) {
        list = list.filter(l => l.KindOfBook.CodeKindBook == filter.kind.CodeKindBook)
      }
      
      if (filter.bookname != undefined && filter.bookname!='') {
        list = list.filter(l => l.NameBook.toLowerCase().indexOf(filter.bookname.trim().toLowerCase()) != -1)
      }
      
      if (filter.author!= undefined && filter.author.trim()!='') {
        list = list.filter(l => l.Author.NameAuthor.toLowerCase().indexOf(filter.author.toLowerCase()) != -1)
        
      }
    }
 
    return list;



  }

}

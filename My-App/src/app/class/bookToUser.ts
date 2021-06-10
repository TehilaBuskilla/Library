
import { ReadingBooks } from "./readingBooks";
import { Users } from "./users";

export class BookToUser {
    constructor(
        public CodeBookToUser?: number,
        public BookCode?: number,
        public UserId?: string,
        public Like?:boolean,
        public LastDate?:Date,
        public Count?:number,
       
    ) {

    }
}
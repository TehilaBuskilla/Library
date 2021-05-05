
import { ReadingBooks } from "./readingBooks";
import { Users } from "./users";

export class BookToUser {
    constructor(
        public CodeBookToUser?: number,
        public BookCode?: ReadingBooks,
        public UserId?: Users,
       
    ) {

    }
}
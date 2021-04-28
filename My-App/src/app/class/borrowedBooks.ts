import { ReadingBooksService } from "../services/reading-books.service";
import { ReadingBooks } from "./readingBooks";
import { Users } from "./users";

export class BorrowedBooks {
    constructor(
        public CodeBorrowedBooks?: number,
        public BookCode?: ReadingBooks,
        public UserId?: Users,
        public BorrowingDate?: Date,
        public IsBorrowed?: boolean,
    ) {

    }
}
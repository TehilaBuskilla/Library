import { Audiences } from "./audiences";
import { Authors } from "./authors";
import { Genders } from "./genders";
import { KindsOfBooks } from "./kindsOfBooks";
import { StatusForUsers } from "./statusForUsers";

export class ReadingBooks {
    constructor(
        public CodeBook?: number,
        public NameBook?: string,
        public Author?: Authors,
        public KindOfBook?: KindsOfBooks,
        public Audience?: Audiences,
        public LengthBook?: number,
        public IsBorrowed?: boolean,
        public Status?: StatusForUsers,
        public Gender?: Genders
    ) {

    }
}
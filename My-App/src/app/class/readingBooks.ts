import { Audiences } from "./audiences";
import { Authors } from "./authors";
import { Genders } from "./genders";
import { KindsOfBooks } from "./kindsOfBooks";
import { StatusForUsers } from "./statusForUsers";
import { StatusUser } from "./statusUser";

export class ReadingBooks {
    constructor(
        public CodeBook?: number,
        public NameBook?: string,
        public Author?: Authors,
        public KindOfBook?: KindsOfBooks,
        public Audience?: Audiences,
        public LengthBook?: number,
        public IsBorrowed?: boolean,
        public StatusUser?: StatusUser,
        public Gender?: Genders,
        public ImgBook?:string,
    ) {

    }
}
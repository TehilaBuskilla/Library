import { Authors } from "./authors";
import { Users } from "./users";

export class AuthorsForUsers {
    constructor(
        public CodeAuthorsForUsers?: number,
        public Author?: Authors,
        public UserId?: Users,
    ) {

    }
}
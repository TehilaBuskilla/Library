import { KindsOfBooks } from "./kindsOfBooks";
import { Users } from "./users";

export class KindsOfBooksForUsers {
    constructor(
        public CodeKindsOfBooksForUsers?: number,
        public UserId?: Users,
        public KindOfBook?: KindsOfBooks,
    ) {

    }
}
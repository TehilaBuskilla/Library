import { style } from "@angular/animations";
import { pathToFileURL } from "url";
import { ServiceService } from "../services/service.service";
import { ReadingBooks } from "./readingBooks";
import { Users } from "./users";

export class WishList {
    constructor(
        public CodeWishList?: number,
        public BookCode?: number,
        public UserId?: string,
        

    ) {

    }
}


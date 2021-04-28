import { ReadingBooks } from "./readingBooks";

export class ProfileBook {
    constructor(
        public CodeProfileBook?: number,
        public BookCode?: ReadingBooks,
        public KindBook?: number,
        public AudienceAge?: number,
        public AudienceStatus?: number,
        public AudienceGender?: number,
    ) {

    }
}
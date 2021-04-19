export class BorrowedBooks {
    constructor(
        public codeBorrowedBooks?: number,
        public bookCode?: number,
        public userId?: number,
        public borrowingDate?: Date,
        public isBorrowed?: boolean,
    ) {

    }
}
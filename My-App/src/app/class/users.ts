import { Genders } from "./genders";
import { StatusUser } from "./statusUser";

export class Users {
    constructor(
        public IdUser?: number,
        public NameUser?: string,
        public AgeUser?: number,
        public Gender?: Genders,
        public Status?: StatusUser,
    ) {

    }
}
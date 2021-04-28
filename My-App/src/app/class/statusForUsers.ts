import { StatusUser } from "./statusUser";
import { Users } from "./users";

export class StatusForUsers {
    constructor(
        public CodeStatusForUsers?: number,
        public Status?: StatusUser,
        public UserId?: Users,
    ) {

    }
}
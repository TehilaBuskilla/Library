import { Audiences } from "./audiences";
import { Users } from "./users";

export class AudiencesForUsers {
    constructor(
        public CodeAudiencesForUsers?: number,
        public Audience?: Audiences,
        public UserId?: Users,
    ) {

    }
}
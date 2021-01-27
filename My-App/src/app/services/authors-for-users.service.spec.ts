import { TestBed } from '@angular/core/testing';

import { AuthorsForUsersService } from './authors-for-users.service';

describe('AuthorsForUsersService', () => {
  let service: AuthorsForUsersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthorsForUsersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

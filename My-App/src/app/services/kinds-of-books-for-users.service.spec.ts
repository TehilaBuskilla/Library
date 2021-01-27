import { TestBed } from '@angular/core/testing';

import { KindsOfBooksForUsersService } from './kinds-of-books-for-users.service';

describe('KindsOfBooksForUsersService', () => {
  let service: KindsOfBooksForUsersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KindsOfBooksForUsersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

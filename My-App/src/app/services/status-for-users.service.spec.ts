import { TestBed } from '@angular/core/testing';

import { StatusForUsersService } from './status-for-users.service';

describe('StatusForUsersService', () => {
  let service: StatusForUsersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StatusForUsersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

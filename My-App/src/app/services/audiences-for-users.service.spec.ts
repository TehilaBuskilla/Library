import { TestBed } from '@angular/core/testing';

import { AudiencesForUsersService } from './audiences-for-users.service';

describe('AudiencesForUsersService', () => {
  let service: AudiencesForUsersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AudiencesForUsersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

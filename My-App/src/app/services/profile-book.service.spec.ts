import { TestBed } from '@angular/core/testing';

import { ProfileBookService } from './profile-book.service';

describe('ProfileBookService', () => {
  let service: ProfileBookService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProfileBookService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

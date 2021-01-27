import { TestBed } from '@angular/core/testing';

import { KindsOfBooksService } from './kinds-of-books.service';

describe('KindsOfBooksService', () => {
  let service: KindsOfBooksService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KindsOfBooksService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

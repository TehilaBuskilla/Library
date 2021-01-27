import { TestBed } from '@angular/core/testing';

import { ReadingBooksService } from './reading-books.service';

describe('ReadingBooksService', () => {
  let service: ReadingBooksService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReadingBooksService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

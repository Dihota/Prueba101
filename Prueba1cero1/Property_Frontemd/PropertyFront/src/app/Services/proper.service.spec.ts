import { TestBed } from '@angular/core/testing';

import { ProperService } from './proper.service';

describe('ProperService', () => {
  let service: ProperService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProperService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

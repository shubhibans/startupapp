import { TestBed, inject } from '@angular/core/testing';

import { BuildExamService } from './build-exam.service';

describe('BuildExamService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BuildExamService]
    });
  });

  it('should be created', inject([BuildExamService], (service: BuildExamService) => {
    expect(service).toBeTruthy();
  }));
});

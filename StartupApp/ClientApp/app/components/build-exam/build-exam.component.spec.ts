import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildExamComponent } from './build-exam.component';

describe('BuildExamComponent', () => {
  let component: BuildExamComponent;
  let fixture: ComponentFixture<BuildExamComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BuildExamComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildExamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

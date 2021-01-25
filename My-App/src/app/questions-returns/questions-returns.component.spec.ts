import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionsReturnsComponent } from './questions-returns.component';

describe('QuestionsReturnsComponent', () => {
  let component: QuestionsReturnsComponent;
  let fixture: ComponentFixture<QuestionsReturnsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuestionsReturnsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestionsReturnsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EspeciallyForYouComponent } from './especially-for-you.component';

describe('EspeciallyForYouComponent', () => {
  let component: EspeciallyForYouComponent;
  let fixture: ComponentFixture<EspeciallyForYouComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EspeciallyForYouComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EspeciallyForYouComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

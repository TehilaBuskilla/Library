import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SigninmessageComponent } from './signinmessage.component';

describe('SigninmessageComponent', () => {
  let component: SigninmessageComponent;
  let fixture: ComponentFixture<SigninmessageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SigninmessageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SigninmessageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

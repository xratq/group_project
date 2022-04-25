import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForkComponent } from './fork.component';

describe('ForkComponent', () => {
  let component: ForkComponent;
  let fixture: ComponentFixture<ForkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ForkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ForkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

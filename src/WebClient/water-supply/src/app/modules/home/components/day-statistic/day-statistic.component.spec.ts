import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DayStatisticComponent } from './day-statistic.component';

describe('DayStatisticComponent', () => {
  let component: DayStatisticComponent;
  let fixture: ComponentFixture<DayStatisticComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DayStatisticComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DayStatisticComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

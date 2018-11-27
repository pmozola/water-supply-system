import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-current-measurement',
  templateUrl: './current-measurement.component.html',
  styleUrls: ['./current-measurement.component.css']
})
export class CurrentMeasurementComponent implements OnInit {

  constructor() { }
  @Input() measureCardModel: MeasureCardModel;

  ngOnInit() {
  }

}

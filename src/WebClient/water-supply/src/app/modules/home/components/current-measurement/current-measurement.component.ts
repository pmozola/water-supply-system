import { Component, OnInit, Input } from '@angular/core';
import { MeasureCardModel } from 'src/app/shared/models/measure-card-model';

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

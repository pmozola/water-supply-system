import { Component, Input, OnInit } from '@angular/core';
import { StatisticCardModel } from 'src/app/shared/models/statistic-card-model';
import { MeasurementType } from 'src/app/shared/models/measurement-enum';
import * as moment from 'moment';

@Component({
  selector: 'app-measurement-statistic',
  templateUrl: './measurement-statistic.component.html',
  styleUrls: ['./measurement-statistic.component.css']
})
export class MeasurementStatisticComponent implements OnInit {


  @Input() model: StatisticCardModel;
  public lineChartData: Array<any>;
  public lineChartLabels: Array<any>;

  public lineChartOptions: any = {
    responsive: true
  };

  public lineChartColors: Array<any> = [
    {
      fillColor: 'rgba(151,187,205,1)',
      strokeColor: 'rgba(151,187,205,1)',
      pointColor: 'rgba(151,187,205,1)',
      pointStrokeColor: '#fff',
      pointHighlightFill: '#fff',
      pointHighlightStroke: 'rgba(151,187,205,0.8)'
    }
  ];
  public lineChartLegend: boolean = true;
  public lineChartType: string = 'line';

  constructor() {
  }

  ngOnInit(): void {

    this.lineChartData =  [{data: this.PreapareData(), label: this.model.name }];

    this.lineChartLabels = this.PreapareChartLabels();
  }

  PreapareChartLabels(): any[] {
    return this.model.daylog.map(x => moment(x.date).toDate().getTime());
  }

  private PreapareData(): Array<any> {
    const data = [];
    if (this.model.measurementType === MeasurementType.humidity) {
      this.model.daylog.forEach(element => {
        data.push(element.humidity);
      });
    }

    if (this.model.measurementType === MeasurementType.soilHumidity) {
      this.model.daylog.forEach(element => {
        data.push(element.soilHumidity);
      });
    }
    if (this.model.measurementType === MeasurementType.temperature) {
      this.model.daylog.forEach(element => {
        data.push(element.temperature);
      });
    }
    if (this.model.measurementType === MeasurementType.lightIntensity) {
      this.model.daylog.forEach(element => {
        data.push(element.lightIntensity);
    });
    }
    return data;
  }


  // events
  public chartClicked(e: any): void {
    console.log(e);
  }

  public chartHovered(e: any): void {
    console.log(e);
  }
}

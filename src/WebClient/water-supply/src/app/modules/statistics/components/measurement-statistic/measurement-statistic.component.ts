import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-measurement-statistic',
  templateUrl: './measurement-statistic.component.html',
  styleUrls: ['./measurement-statistic.component.css']
})
export class MeasurementStatisticComponent {
  @Input() name: string;

  public lineChartData: Array<any> = [
    {data: [65, 59, 80, 81, 56, 55, 40], label: this.name}
  ];
  public lineChartLabels: Array<any> = ['12:00', '13:00', '14:00', '15:00', '16:00', '17:00', '18:00'];
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
  public lineChartLegend:boolean = true;
  public lineChartType:string = 'line';

  // events
  public chartClicked(e:any):void {
    console.log(e);
  }

  public chartHovered(e:any):void {
    console.log(e);
  }

}

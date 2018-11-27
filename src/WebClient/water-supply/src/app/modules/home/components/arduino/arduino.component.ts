import { Component, OnInit, Input } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api.service';
import { SignalRHubService } from 'src/app/shared/services/signalr-hub.service';
import { HubConnection } from '@aspnet/signalr';

@Component({
  selector: 'app-arduino',
  templateUrl: './arduino.component.html',
  styleUrls: ['./arduino.component.css']
})
export class ArduinoComponent implements OnInit {
  private _hubConnection: HubConnection;
  measureCardModel = [] as MeasureCardModel[];

  @Input() arduinoId: number;
  constructor(
    private apiService: ApiService,
    private signalr: SignalRHubService
  ) {
    this._hubConnection = this.signalr.GetConnection();
    this._hubConnection.on('BroadcastMessage', (measurement: Measurement) => {
      if (measurement.arduinoId === this.arduinoId) {
        this.measureCardModel = this.prepareModel(measurement);
      }
    });
  }

  ngOnInit() {
    this.apiService
      .Get(this.arduinoId)
      .subscribe(resp => (this.measureCardModel = this.prepareModel(resp)));
  }

  private prepareModel(measurement: Measurement): MeasureCardModel[] {
    const returnValue = [] as MeasureCardModel[];
    returnValue.push({
      data: measurement.temperature,
      name: 'Temperatura',
      arduinoId: measurement.arduinoId
    } as MeasureCardModel);
    returnValue.push({
      data: measurement.humidity,
      name: 'Wilgotnosc',
      arduinoId: measurement.arduinoId
    } as MeasureCardModel);
    returnValue.push({
      data: measurement.soilHumidity,
      name: 'Wilgotność ziemi',
      arduinoId: measurement.arduinoId
    } as MeasureCardModel);

    if (measurement.lightIntensity) {
      returnValue.push({
        data: measurement.lightIntensity,
        name: 'Natężenie Światła',
        arduinoId: measurement.arduinoId
      } as MeasureCardModel);
    }

    return returnValue;
  }
}

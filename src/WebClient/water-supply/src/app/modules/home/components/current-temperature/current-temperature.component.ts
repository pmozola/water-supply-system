import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-current-temperature',
  templateUrl: './current-temperature.component.html',
  styleUrls: ['./current-temperature.component.css']
})
export class CurrentTemperatureComponent implements OnInit {
  private _hubConnection: HubConnection;
  temperature = {} as Temperature;

  constructor() {}

  ngOnInit() {
    this._hubConnection = new HubConnectionBuilder()
      .withUrl(environment.apiUrl + 'notify')
      .build();

    this._hubConnection
      .start()
      .then(
        () => console.log('Connection started!'))
      .catch(err => console.log('Error while establishing connection :('));

    this._hubConnection.on(
      'BroadcastMessage',
      (temperature: Temperature) => {
        this.temperature = temperature;
      }
    );
  }
}

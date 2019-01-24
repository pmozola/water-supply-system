import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder, IHttpConnectionOptions } from '@aspnet/signalr';
import { environment } from 'src/environments/environment';
import * as signalR from '@aspnet/signalr';

@Injectable({
  providedIn: 'root'
})
export class SignalRHubService {

  private _hubConnection: HubConnection;

  constructor() {
    const option = { skipNegotiation: true, transport: signalR.HttpTransportType.WebSockets} as IHttpConnectionOptions;
    this._hubConnection = new HubConnectionBuilder()
    .withUrl(environment.apiUrl + 'notify', option)
    .build();

    this._hubConnection
    .start()
    .then(
      () => console.log('Connection started!'))
    .catch(err => console.log('Error while establishing connection.'));
  }

  GetConnection(): HubConnection {
    return this._hubConnection;
      }
  }

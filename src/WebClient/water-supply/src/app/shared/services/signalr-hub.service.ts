import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SignalRHubService {

  private _hubConnection: HubConnection;

  constructor() {
    this._hubConnection = new HubConnectionBuilder()
    .withUrl(environment.apiUrl + 'notify')
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

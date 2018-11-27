import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private httpClient: HttpClient) {}
  // TODO dodac zmienic klase na viewmodel
  Get(arduinoId: number): Observable<any>  {
    return this.httpClient.get(
      environment.apiUrl + 'api/Measurement/latest/' + arduinoId
    );
  }
}

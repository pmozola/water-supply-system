import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { DayMeasurementStatitic } from '../models/day-measurement-statitic';
import { Measurement } from '../models/measurement';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private httpClient: HttpClient) {}
  // TODO dodac zmienic klase na viewmodel
  Get(arduinoId: number): Observable<any> {
    return this.httpClient.get(
      environment.apiUrl + 'api/Measurement/latest/' + arduinoId
    );
  }

  GetDayLog(arduinoId: number): Observable<Measurement[]> {
    return this.httpClient.get<Measurement[]>(
      environment.apiUrl + 'api/Measurement/latest/log/' + arduinoId
    );
  }

  GetDayStatistic(arduinoId: number): Observable<DayMeasurementStatitic> {
    return this.httpClient.get<DayMeasurementStatitic>(
      environment.apiUrl + 'api/Statistic/' + arduinoId
    );
  }
}

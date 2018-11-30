import { Component } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api.service';
import { DayMeasurementStatitic } from 'src/app/shared/models/day-measurement-statitic';
import { StatisticCardModel } from 'src/app/shared/models/statistic-card-model';
import { ActivatedRoute } from '@angular/router';
import { forkJoin } from 'rxjs';
import { Measurement } from 'src/app/shared/models/measurement';
import { MeasurementType } from 'src/app/shared/models/measurement-enum';

@Component({
  selector: 'app-day',
  templateUrl: './day.component.html',
  styleUrls: ['./day.component.css']
})
export class DayComponent {
  temperatureCard: StatisticCardModel;
  soileCard: StatisticCardModel;
  humidityCard: StatisticCardModel;
  lightCard: StatisticCardModel;
  arduinoId: number;

  constructor(private route: ActivatedRoute, apiService: ApiService) {
    this.arduinoId = +this.route.snapshot.paramMap.get('id');
    const datStats = apiService.GetDayStatistic(this.arduinoId);
    const dayLog = apiService.GetDayLog(this.arduinoId);

    forkJoin([datStats, dayLog]).subscribe(results =>
      this.PreaperMeasurmentCardModles(results[0], results[1])
    );
  }

  private PreaperMeasurmentCardModles(
    dayStatistic: DayMeasurementStatitic,
    daylog: Measurement[]
  ) {
    this.temperatureCard = {
      name: 'Temperatura',
      arduinoId: this.arduinoId,
      measurementType: MeasurementType.temperature,
      daylog: daylog,
      dayStatistic: dayStatistic.DayTemperatureStatistic
    } as StatisticCardModel;
    this.humidityCard = {
      name: 'Wilgotność',
      arduinoId: this.arduinoId,
      measurementType: MeasurementType.humidity,
      daylog: daylog,
      dayStatistic: dayStatistic.DayTemperatureStatistic
    } as StatisticCardModel;
    this.soileCard = {
      name: 'Wilgotność ziemi',
      measurementType: MeasurementType.soilHumidity,
      arduinoId: this.arduinoId,
      daylog: daylog,
      dayStatistic: dayStatistic.DayTemperatureStatistic
    } as StatisticCardModel;
    this.lightCard = {
      name: 'Natęzenie Światła',
      arduinoId: this.arduinoId,
      measurementType: MeasurementType.lightIntensity,
      daylog: daylog,
      dayStatistic: dayStatistic.DayTemperatureStatistic
    } as StatisticCardModel;
  }
}

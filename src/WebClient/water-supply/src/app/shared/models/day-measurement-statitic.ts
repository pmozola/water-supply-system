import { DayStatistic } from './day-statistic';

export interface DayMeasurementStatitic {
  DayTemperatureStatistic: DayStatistic;
  DayHumidityStatistic: DayStatistic;
  DaySoilHumidityStatistic: DayStatistic;
  DayLightIntensityStatistic: DayStatistic;
}

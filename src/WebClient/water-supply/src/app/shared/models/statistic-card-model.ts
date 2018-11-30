import { Measurement } from './measurement';
import { DayStatistic } from './day-statistic';
import { MeasurementType } from './measurement-enum';

export interface StatisticCardModel {
  name: string;
  measurementType: MeasurementType;
  arduinoId: number;
  dayStatistic: DayStatistic;
  daylog: Measurement[];
}

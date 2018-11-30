import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StatisticsRoutingModule } from './statistics-routing.module';
import { DayComponent } from './pages/day/day.component';
import { MeasurementStatisticComponent } from './components/measurement-statistic/measurement-statistic.component';
import { AppMatModuleModule } from 'src/app/shared/modules/app-mat-module/app-mat-module.module';
import { ChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    DayComponent,
    DayComponent,
    MeasurementStatisticComponent
  ],
  imports: [
    CommonModule,
    StatisticsRoutingModule,
    AppMatModuleModule,
    ChartsModule,
  ]
})
export class StatisticsModule { }

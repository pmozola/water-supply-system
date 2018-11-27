import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './page/home/home.component';
import { AppMatModuleModule } from 'src/app/shared/modules/app-mat-module/app-mat-module.module';
import { ArduinoComponent } from './components/arduino/arduino.component';
import { DayStatisticComponent } from './components/day-statistic/day-statistic.component';
import { ChartsModule } from 'ng2-charts';
import { CurrentMeasurementComponent } from './components/current-measurement/current-measurement.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    HomeComponent,
    ArduinoComponent,
    DayStatisticComponent,
    CurrentMeasurementComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    AppMatModuleModule,
    ChartsModule,
    HttpClientModule
  ]
})
export class HomeModule {}

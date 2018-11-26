import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { CurrentTemperatureComponent } from './components/current-temperature/current-temperature.component';
import { CurrentHumidityComponent } from './components/current-humidity/current-humidity.component';
import { CurrentSoilHumidityComponent } from './components/current-soil-humidity/current-soil-humidity.component';
import { HomeComponent } from './page/home/home.component';
import { MatRippleModule } from '@angular/material';
import { AppMatModuleModule } from 'src/app/shared/modules/app-mat-module/app-mat-module.module';

@NgModule({
  declarations: [HomeComponent, CurrentTemperatureComponent, CurrentHumidityComponent, CurrentSoilHumidityComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    AppMatModuleModule
  ]
})
export class HomeModule { }

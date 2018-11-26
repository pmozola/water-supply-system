import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './shared/components/navbar/navbar.component';
import { MatIconModule, MatButtonModule, MatSidenavModule, MatToolbarModule, MatCardModule } from '@angular/material';
import { AppMatModuleModule } from './shared/modules/app-mat-module/app-mat-module.module';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    AppMatModuleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

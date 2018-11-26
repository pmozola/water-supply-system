import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AboutRoutingModule } from './about-routing.module';
import { AboutComponent } from './page/about/about.component';
import { PersonInfoComponent } from './components/person-info/person-info.component';
import { ProjectInformationComponent } from './components/project-information/project-information.component';

@NgModule({
  declarations: [AboutComponent, PersonInfoComponent, ProjectInformationComponent],
  imports: [
    CommonModule,
    AboutRoutingModule
  ]
})
export class AboutModule { }

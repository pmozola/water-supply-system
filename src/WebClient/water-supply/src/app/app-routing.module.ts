import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: 'about', loadChildren: './modules/about/about.module#AboutModule' },
  { path: '', loadChildren: './modules/home/home.module#HomeModule' },
  { path: 'statistics', loadChildren: './modules/statistics/statistics.module#StatisticsModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserComponent } from './models/user/user.component';
import { ResourceComponent } from './models/resource/resource.component';
import { EventComponent } from './models/event/event.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './services/auth-guard.service';
import { DashboardComponent } from './models/dashboard/dashboard.component';
import { EventsCalendarComponent } from './models/events-calendar/events-calendar.component'

const routes: Routes = [
    { path: 'user', component: UserComponent, canActivate: [AuthGuardService] },
    { path: 'event', component: EventsCalendarComponent, canActivate: [AuthGuardService] },
    { path: 'singleevent', component: EventComponent, canActivate: [AuthGuardService] },
    { path: '**', component: UserComponent, canActivate: [AuthGuardService] },
    { path: '**', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

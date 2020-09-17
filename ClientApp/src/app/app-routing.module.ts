import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserComponent } from './models/user/user.component';
import { ResourceComponent } from './models/resource/resource.component';
import { EventComponent } from './models/event/event.component';
import { EventsCalendarComponent } from './models/events-calendar/events-calendar.component'

const routes: Routes = [
  { path: 'user', component: UserComponent },
  { path: 'resource', component: ResourceComponent },
  { path: 'event', component: EventsCalendarComponent },
  { path: 'singleevent', component: EventComponent },
  { path: '**', component: UserComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

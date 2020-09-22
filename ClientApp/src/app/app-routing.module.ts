import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserComponent } from './models/user/user.component';
import { ResourceComponent } from './models/resource/resource.component';
import { EventComponent } from './models/event/event.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './services/auth-guard.service';
import { DashboardComponent } from './models/dashboard/dashboard.component';
import { SingleUserComponent } from './models/user/single-user/single-user.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'user', component: UserComponent, canActivate: [AuthGuardService] },
  { path: 'single-user', component: SingleUserComponent, canActivate: [AuthGuardService] },
  { path: 'single-user/:id', component: SingleUserComponent, canActivate: [AuthGuardService] },
  { path: 'resource', component: ResourceComponent },
  { path: 'event', component: EventComponent, canActivate: [AuthGuardService] },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserComponent } from './models/user/user.component';
import { ResourceComponent } from './models/resource/resource.component';
import { EventComponent } from './models/event/event.component';
import { ExerciseComponent } from './models/exercise/exercise.component';
import { ExerciseDetailComponent } from './models/exercise/exercise-detail/exercise-detail.component';
import { TeachingMaterialComponent } from './models/teaching-material/teaching-material.component';

const routes: Routes = [
  { path: '', redirectTo: '/user', pathMatch: 'full' },
  { path: 'user', component: UserComponent },
  { path: 'resource', component: ResourceComponent },
  { path: 'event', component: EventComponent },
  { path: 'exercise', component: ExerciseComponent },
  { path: 'exercise-detail', component: ExerciseDetailComponent },
  { path: 'teaching-material', component: TeachingMaterialComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

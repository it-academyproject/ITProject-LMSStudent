import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from '@angular/common/http' ;

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ResourceComponent } from './models/resource/resource.component';
import { EventComponent } from './models/event/event.component';
import { UserComponent } from './models/user/user.component';
import { ExerciseComponent } from './models/exercise/exercise.component';
import { TeachingMaterialComponent } from './models/teaching-material/teaching-material.component';
import { ExerciseDetailComponent } from './models/exercise/exercise-detail/exercise-detail.component';
import { TopicComponent } from './models/topic/topic.component';

@NgModule({
  declarations: [
    AppComponent,
    ResourceComponent,
    EventComponent,
    UserComponent,
    ExerciseComponent,
    TeachingMaterialComponent,
    ExerciseDetailComponent,
    TopicComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

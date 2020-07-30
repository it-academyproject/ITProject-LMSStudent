import { Component, OnInit } from '@angular/core';
import { Exercise } from './exercise';
import { ExerciseService } from './exercise.service';


@Component({
  selector: 'app-exercise',
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.css']
})
export class ExerciseComponent implements OnInit {

  public exercises: Exercise[];
  
  constructor(private exerciseService: ExerciseService) { }

  ngOnInit(): void {
    this.getExercises();
  }

  getExercises(): void {
    this.exerciseService.getExercises()
    .subscribe(exercises => this.exercises = exercises);
  }

  delete(exercise: Exercise): void {
    this.exercises = this.exercises.filter(e => e !== exercise);
    this.exerciseService.deleteExercise(exercise).subscribe();
  }

}
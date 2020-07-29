import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Exercise } from '../exercise/exercise';

@Injectable({
  providedIn: 'root'
})
export class ExerciseService {

  private apiUrl = 'https://localhost:44392/api/exercises';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  constructor(private http: HttpClient) { }

  getExercises(): Observable<Exercise[]>{
    return this.http.get<Exercise[]>(this.apiUrl, this.httpOptions);
  }

  getExercise(id: string): Observable<Exercise> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<Exercise>(url);
  }

  updateExercise(exercise: Exercise): Observable<Exercise> {
    return this.http.put<Exercise>(this.apiUrl + "/" + exercise.id.toString(), exercise, this.httpOptions);
  }

  addExercise(exercise: Exercise): Observable<Exercise> {
    return this.http.post<Exercise>(this.apiUrl, exercise, this.httpOptions);
  }

  deleteExercise(exercise: Exercise | number): Observable<Exercise> {
    const id = typeof exercise === 'number' ? exercise : exercise.id;
    const url = `${this.apiUrl}/${id}`;

    return this.http.delete<Exercise>(url, this.httpOptions);
  }
}

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Itinerary } from './itinerary';

@Injectable({
  providedIn: 'root'
})
export class ItineraryService {

  private apiUrl = 'api/itineraries';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json'})
  }

  constructor(private http: HttpClient) { }

  getItineraries(): Observable<Itinerary[]>{
    return this.http.get<Itinerary[]>(this.apiUrl);
  }

}

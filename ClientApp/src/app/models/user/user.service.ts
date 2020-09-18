import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private apiUrl = 'api/users';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json'})
  }

  constructor(private http: HttpClient) { }

  getUsers(): Observable<User[]>{
    return this.http.get<User[]>(this.apiUrl);
  }

  getUser(id: string): Observable<User> {
    const url = `${this.apiUrl}/${id}`;
    
    return this.http.get<User>(url);
  }

  updateUser(user: User): Observable<User> {
    return this.http.put<User>(this.apiUrl + "/" + user.id, user, this.httpOptions);
  }

  addUser(user: User): Observable<User> {
    return this.http.post<User>(this.apiUrl, user, this.httpOptions);
  }

  deleteUser(user: User | number): Observable<User> {
    const id = typeof user === 'number' ? user : user.id;
    const url = `${this.apiUrl}/${id}`;

    return this.http.delete<User>(url, this.httpOptions);
  }
}

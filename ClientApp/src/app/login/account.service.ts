import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IUserInfo } from '../login/user-info';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  private apiURL = 'api/account';

  constructor(
    private http: HttpClient) { }

  create(userInfo: IUserInfo): Observable<any> {
    return this.http.post<any>(this.apiURL + "/Create", userInfo);
  }

  login(userInfo: IUserInfo): Observable<any> { 
    return this.http.post<any>(this.apiURL + "/Login", userInfo);
  }

  getToken(): string {
    return localStorage.getItem("token");
  }

  getTokenExpiration(): string {
    return localStorage.getItem("tokenExpiration");
  }

  logout() {
    localStorage.removeItem("token");
    localStorage.removeItem("tokenExpiration");
    localStorage.removeItem("userType");
  }

  isLogged(): boolean {

    var exp = this.getTokenExpiration();

    if (!exp) {
      // The token doesn't exist
      return false;
    }

    var now = new Date().getTime();
    var dateExp = new Date(exp);

    if (now >= dateExp.getTime()) {
      // The token is already expired
      localStorage.removeItem('token');
      localStorage.removeItem('tokenExpiration');
      localStorage.removeItem('userType');
      return false;
    } else {
      return true;
    }    
  }
}

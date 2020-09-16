import { Component } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { Router } from '@angular/router';
import { AccountService } from './login/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'IT Academy - Admin';
  background: ThemePalette = 'primary';
  activeLink;

  constructor(private accountService: AccountService,
    private router: Router) {}

    isExpanded = false;
    public userType = '';

    collapse() {
      this.isExpanded = false;
    }

    toggle() {
      this.isExpanded = !this.isExpanded;
    }

    logout() {
      this.accountService.logout();
      this.userType = '';
      this.router.navigate(['/login']);
    }

    isLogged() {
      if (this.accountService.isLogged()) {
        this.userType = localStorage.getItem('userType');
        return true;
      }
       return false;
    }
}
import { Component } from '@angular/core';
import { AccountService } from './login/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'LMSStudent';  
  
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

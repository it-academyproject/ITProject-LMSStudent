import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { user } from './user';
import { EnrollmentService } from './enrollment.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html'
})

export class AddUserComponent {

  typeUsers = ['teacher', 'student', 'admin'];
  userModel = new user("", "", "", "", 0);

  constructor(private _enrollmentService: EnrollmentService) {}
  

  onSubmit() {
    this._enrollmentService.enroll(this.userModel)
      .subscribe(
        data => console.log('Success!!', data),
        error => console.log('Error!!', error)
      )
  }
}



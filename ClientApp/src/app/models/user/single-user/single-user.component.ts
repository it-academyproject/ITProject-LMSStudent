import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { User } from '../user';
import { Itinerary } from '../itinerary';
import { UserService } from '../user.service';
import { ItineraryService } from '../itinerary.service';

@Component({
  selector: 'app-single-user',
  templateUrl: './single-user.component.html',
  styleUrls: ['./single-user.component.css']
})
export class SingleUserComponent implements OnInit {

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private userService: UserService,
    private itineraryService: ItineraryService,
    private location: Location
  ) { }

  editionMode: boolean = false;
  formGroup: FormGroup;
  userId: any;

  users: User[];
  itineraries: Itinerary[];

  ngOnInit(): void {
    this.formGroup = this.fb.group({
      name: '',
      surname: '',
      email: '',
      type: '',
      itinerary: ''
    });  

    this.itineraryService.getItineraries()
    .subscribe(itineraries => this.itineraries = itineraries);
   
    this.route.params.subscribe(params => {
      if (params["id"] == undefined){
        return;
      }
      this.editionMode = true;

      this.userId = params["id"];

      this.userService.getUser(this.userId.toString())
      .subscribe(user => this.loadForm(user));
    });
  }

  loadForm(user: User){
    this.formGroup.patchValue({
      name: user.name,
      surname: user.surname,
      email: user.email,
      type: user.type,
      itinerary: user.itinerary
    })
  }

  save() {
    let user: User = Object.assign({}, this.formGroup.value);
    console.table(user);

    if (this.editionMode){
      //edit user
      user.id = this.userId;      
      this.userService.updateUser(user)
      .subscribe();
    } else {
      //add user
      this.userService.addUser(user)
      .subscribe();
    }    
  }
  
  goBack(): void {
    this.location.back();
  }

}

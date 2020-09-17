import { Component } from '@angular/core';  
import { CalendarOptions } from '@fullcalendar/angular';

@Component({  
  selector: 'app-events-calendar',
  templateUrl: './events-calendar.component.html',
  styleUrls: ['./events-calendar.component.css'] 
})  
export class EventsCalendarComponent { 

  calendarOptions: CalendarOptions = {

    initialView: 'dayGridMonth',

  }; 
}

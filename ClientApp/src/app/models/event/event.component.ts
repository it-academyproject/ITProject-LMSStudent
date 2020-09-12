import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, JsonpClientBackend } from '@angular/common/http';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {
  title = 'Events'; 
  baseUrl = 'https://localhost:44368/api/events';
  currentEvents: Events[] = [];

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<Events[]>(this.baseUrl).subscribe(result => {  
      this.currentEvents = result;  
    }, error => console.error(error));
  }

  check(array) {
    for(var i = 0; i < array.length; i += 1) {
      if(array[i] == "") {
          return false;
      }
    }
    return true;
  }

  add(_name, _description, _date, _file, _online, _capacity, _type) {
    var input = [ _name ];
    
    if (!this.check(input))
    {
      alert("Event must have a name!");
      return;
    }

    var newEvent;

    if (+_capacity)
    {
      newEvent = { 
        name: _name,  
        description: _description,
        date: _date, 
        file: _file,
        online: !!(+_online),
        capacity: +_capacity,
        type: _type
      }
    }
    else
    {
      newEvent = { 
        name: _name,  
        description: _description,
        date: _date, 
        file: _file,
        online: !!(+_online),
        capacity: null,
        type: _type
      }
    }

    this.http.post<Events>(this.baseUrl, newEvent, this.httpOptions).subscribe(newEvent => {
      this.currentEvents.push(newEvent)
    });
  }

}

interface Events {  
  id?: number;  
  name: string;  
  description?: string;  
  date?;  
  file?: string;  
  online?: boolean;
  capacity?: number;
  type?: string;
}

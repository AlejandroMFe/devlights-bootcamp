import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Activity } from 'src/app/_models/activity';

@Component({
  selector: 'app-activities',
  templateUrl: './activities.component.html',
  styleUrls: [ './activities.component.css' ]
})
export class ActivitiesComponent implements OnInit {

  activities: Activity[];

  constructor() {
    this.activities = Activity.getActivities();
  }

  ngOnInit(): void {

  }
}
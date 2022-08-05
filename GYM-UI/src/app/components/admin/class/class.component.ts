import { Component, OnInit } from '@angular/core';
import { Activity } from 'src/app/_models/activity';

@Component({
  selector: 'app-class',
  templateUrl: './class.component.html',
  styleUrls: [ './class.component.css' ]
})
export class ClassComponent implements OnInit {
  activities: Activity[];
  count: number = 1;

  ngOnInit(): void {
    this.activities = Activity.getActivities();
  }

  increaseCount() {
    return this.count++;
  }
  
}

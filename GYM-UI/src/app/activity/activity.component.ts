import { Component, Input, OnInit } from '@angular/core';
import { Activity } from 'src/app/_models/activity';

@Component({
  selector: 'app-activity',
  templateUrl: './activity.component.html',
  styleUrls: [ './activity.component.css' ]
})
export class ActivityComponent implements OnInit {

  @Input() activity!: Activity;

  constructor() { }

  ngOnInit(): void {

  }

  // show message succes on click button
  onClick() {
    alert('Te has inscripto correctamente a ' + this.activity.title);
  }
}

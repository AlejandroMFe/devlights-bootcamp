import { Component, OnInit } from '@angular/core';
import { Activity } from 'src/app/_models/activity';

@Component({
  selector: 'app-lista-student-class',
  templateUrl: './lista-student-class.component.html',
  styleUrls: [ './lista-student-class.component.css' ]
})

export class ListaStudentClassComponent implements OnInit {
  studentsActivities: any[];
  count: number = 1;

  constructor() {
    this.studentsActivities = Activity.getStudentsActivities();
  }

  increaseCount() {
    return this.count++;
  }


  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';
import { Activity } from 'src/app/_models/activity';

@Component({
  selector: 'app-lista-student',
  templateUrl: './lista-student.component.html',
  styleUrls: [ './lista-student.component.css' ]
})
export class ListaStudentComponent implements OnInit {
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

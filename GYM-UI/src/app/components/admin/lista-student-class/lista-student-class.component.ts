import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lista-student-class',
  templateUrl: './lista-student-class.component.html',
  styleUrls: ['./lista-student-class.component.css']
})
export class ListaStudentClassComponent {
  title = 'Lista de estudiantes por clases'
  abs = [
    {
      name: 'Juan Pablo',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'ABS'
    }
    ,
    {
      name: 'Sebastian',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'ABS'
    }
  ]
  pilates = [
    {
      name: 'Steffanie',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'Pilates'
    }
    ,
    {
      name: 'Juana',
      lastname: 'Sanchez',
      age: '20',
      email: 'applied@example.com',
      class: 'Pilates'
    }
    ,
    {
      name: 'Leandro',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'Pilates'
    }
    ,
    {
      name: 'Julian',
      lastname: 'Perezas',
      age: '20',
      email: 'applied@example.com',
      class: 'Pilates'
    }
    ,
    {
      name: 'Ana',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'Pilates'
    }];
  zumba = [
    {
      name: 'Juan',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'zumba'
    },
    {
      name: 'Pedro',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'zumba'
    },
    {
      name: 'Juana',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'zumba'
    }
    ,
    {
      name: 'Julian',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'zumba'
    }
  ]
  weight=[
    {
      name: 'JMarilyn',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'WeightLift'
    }
    ,
    {
      name: 'Ryan',
      lastname: 'Perez',
      age: '20',
      email: 'applied@example.com',
      class: 'WeightLift'
    }
  ]
    
}

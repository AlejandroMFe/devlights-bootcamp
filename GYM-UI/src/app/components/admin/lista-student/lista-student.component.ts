import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lista-student',
  templateUrl: './lista-student.component.html',
  styleUrls: ['./lista-student.component.css']
})
export class ListaStudentComponent{
  title = 'Lista de estudiantes';
  students = [
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
    ,
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
    ,
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
    ,
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
}

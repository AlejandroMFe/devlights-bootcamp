import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class',
  templateUrl: './class.component.html',
  styleUrls: ['./class.component.css']
})
export class ClassComponent {

  classes=[
    {
      name: 'Zumba',
      description: 'Zumba es una actividad de fitness que se realiza en una sala de fitness, en la que los participantes se reunen para realizar una serie de movimientos que se dan en una sesión de 30 minutos. El objetivo de la actividad es mejorar la flexibilidad, la fuerza y la coordinación de los músculos del cuerpo.',
      image: 'https://www.zumba.com/wcsstore/Zumba/images/zumba-logo.png'
    },
    {
      name: 'Pilates',
      description: 'Pilates es una actividad de fitness que se realiza en una sala de fitness, en la que los participantes se reunen para realizar una serie de movimientos que se dan en una sesión de 30 minutos. El objetivo de la actividad es mejorar la flexibilidad, la fuerza y la coordinación de los músculos del cuerpo.',
      image: 'https://www.pilates.com/wcsstore/Pilates/images/pilates-logo.png'
    },
    {
      name: 'ABS',
      description: 'ABS es una actividad de fitness que se realiza en una sala de fitness, en la que los participantes se reunen para realizar una serie de movimientos que se dan en una sesión de 30 minutos. El objetivo de la actividad es mejorar la flexibilidad, la fuerza y la coordinación de los músculos del cuerpo.',
      image: 'https://www.abs.com/wcsstore/ABS/images/abs-logo.png'
    },
    {
      name: 'Yoga',
      description: 'Yoga es una actividad de fitness que se realiza en una sala de fitness, en la que los participantes se reunen para realizar una serie de movimientos que se dan en una sesión de 30 minutos. El objetivo de la actividad es mejorar la flexibilidad, la fuerza y la coordinación de los músculos del cuerpo.',
      image: 'https://www.yoga.com/wcsstore/Yoga/images/yoga-logo.png'
    }
  ]

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-classes',
  templateUrl: './classes.component.html',
  styleUrls: ['./classes.component.css']
})
export class ClassesComponent{

  ctitle = 'Pricing';
    
  classes = ['Zumba', 'Tumbling', 'Weightlifting', 'ABS'] ;
  classesDia = [['Lunes 17:30','Miercoles 16:30','Sabado 17:30'], ['Jueves 7:30','Miercoles 21:30','Sabado 13:30'], ['Viernes 16:30','Miercoles 13:30','Sabado 19:30'], ['Lunes 9:30','Miercoles 14:30','Viernes 11:30']];
  features = ['La mejor oportunidad para entrenarte de manera divertida!', 'Ven a hacer la mejor gimnasia con los mejores profesores!', 'Levanta un caniche o levanta un camion! Es tu decision, nosotros te ayudamos','Quieres un six-pack? Te ayudamos!'];
  images = ['assets/images/basic.jpg', 'assets/images/intermediate.jpg', 'assets/images/advanced.jpg'];

}

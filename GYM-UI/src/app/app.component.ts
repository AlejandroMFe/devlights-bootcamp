import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from './_services/auth.service';
import { User } from './_models/user';
import{ environment } from '../environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'GYM-UI';
  user: any;

  constructor(private httpClient: HttpClient, private authService: AuthService){}

  ngOnInit(){
    console.log(environment.baseUrl);
  }

  setCurrentUser(){
    const user: User = JSON.parse(localStorage.getItem('user') as any);
    this.authService.setCurrentUser(user);
  }
}

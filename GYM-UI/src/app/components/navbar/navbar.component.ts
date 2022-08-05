import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/internal/Observable';
import { User } from '../../_models/user';
import { AuthService } from '../../_services/auth.service';


@Component({
  selector: 'Navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class Navbar implements OnInit {
  user: any;
  currentUser$: any;
  currentUser: any;

  constructor(public authService: AuthService, private router: Router) { }

  ngOnInit(): void {
    this.currentUser$ = localStorage.getItem('user');
    this.currentUser = JSON.parse(localStorage.getItem('user') || '{}');
  }

  login(){
    console.log(this.user);
    this.authService.login(this.user).subscribe({
      //next (paso exitoso)
      next: user => { console.log(user)},
      //nombre | (nombre) | () => { line1; line2 }
      //error (paso erroneo)
      error: error => console.log(error),
      //complete (paso sí o sí)
      complete: () => console.log("complete")
    });
  }

  logout(){
    this.authService.logout();
    this.router.navigate(['/']);
  }

}

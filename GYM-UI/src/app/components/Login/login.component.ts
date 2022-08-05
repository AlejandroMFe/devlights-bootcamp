import {Component, OnInit}from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../../_services/auth.service';

@Component({
    selector: 'Login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css'],
})

export class Login implements OnInit {

    loginForm: FormGroup;
  
    constructor(
      private auth: AuthService, 
      private router: Router,
      private toastr: ToastrService
    ) {}
  
    ngOnInit(): void {
      this.loginForm = new FormGroup({
        username: new FormControl('', Validators.required),
        password: new FormControl('', Validators.required)
      })
    }

    submitLogin(){
        var route = this.router;
        if(this.loginForm.valid){
          console.log(this.loginForm.value);
          this.auth.login(this.loginForm.value).subscribe({
            //next (paso exitoso)
            next: (user) => { console.log(user), this.router.navigate(['/activities']); },
            //nombre | (nombre) | () => { line1; line2 }
            //error (paso erroneo)
            error: (error) => { console.log(error); },
            //complete (paso sí o sí)
            complete: () => console.log("Funciona o no esta porquería")
          });
        }
      }
}
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm : FormGroup;

  constructor(
    private auth: AuthService,
    private formBuilder: FormBuilder,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
      email: ['', Validators.required],
      name: ['', Validators.required],
      birthday: ['', Validators.required],
      phoneNumber: ['', Validators.required]
    })
  }

  submitRegister(){
    var router = this.router;
    const register = this.registerForm.value;
    if(this.registerForm.valid){
      this.auth.register(register).subscribe({
        next: user => {
          console.log(user),
          router.navigate(['../'])
        },
        error: error => console.log(error),
        complete: () => console.log("complete")
      });
    }
  }
}

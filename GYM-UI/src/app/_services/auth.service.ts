import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { Register } from '../_models/register';
import { User } from '../_models/user';
//import { Register } from '../_models/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = "https://localhost:7070/api/";
  currentUser: User = new User();
  private currentUserSubject = new BehaviorSubject<User>(this.currentUser);
  currentUser$ = this.currentUserSubject.asObservable();
  isLoggedIn = false;

  constructor(private httpClient: HttpClient) { 
    if(this.loggedIn()){
      const user: User = JSON.parse(localStorage.getItem('user') || '{}');
      this.setCurrentUser(user);
    }
  }

  login(user: any){
    return this.httpClient.post<User>(this.baseUrl + 'Account/login', user).pipe(
      map((response: User) => {
        const user = response;
        if(user){
          console.log(user);
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSubject.next(user);
        }
      })
    );
  }

  logout(){
    localStorage.removeItem('user');
    this.currentUserSubject.next(null!);
  }

  loggedIn(){
    const user: User = JSON.parse(localStorage.getItem('user')|| '{}');
    return !!user;
  }

  register(register: Register){
    return this.httpClient.post(this.baseUrl + 'account/register', register).pipe(
      map((response: any) => {
        const user = response;
        if(user){
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSubject.next(user);
        }
      })
    );
  }

  setCurrentUser(user: User){
    this.currentUserSubject.next(user);
  }

  public get currentUserValue(){
    return this.currentUserSubject.value
  }
}

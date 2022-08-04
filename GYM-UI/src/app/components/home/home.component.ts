import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  users: any;
  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers(){
    this.httpClient.get('https://localhost:7070/api/AppUsers').subscribe({
      next: r => { this.users = r; console.log(this.users) },
      error: error => console.log(error),
      complete: () => console.log("Complete")
    })
  }

}

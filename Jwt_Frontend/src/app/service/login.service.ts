import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  invalidLogin: boolean;
  isLoggedIn=new BehaviorSubject(false);
  errorData: {};

  constructor(private httpClient: HttpClient,
    private router: Router) { }

  // login(form: NgForm) {
  //   const credentials = JSON.stringify(form.value);
  //   this.httpClient.post("https://localhost:5001/api/Authentication/login", credentials, {
  //     headers: new HttpHeaders({
  //       "Content-Type": "application/json"
  //     })
  //   });
  // }
  logout(){
    localStorage.removeItem("jwt");
    this.isLoggedIn.next(false);
    this.router.navigate(['/login'])
  }
}

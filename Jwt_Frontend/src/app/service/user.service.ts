import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { User } from '../Models/user';



@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl = 'https://localhost:5001/api/Authentication';

  isLoggedIn = new BehaviorSubject(false);
  errorData: {};

  constructor(private httpClient: HttpClient) { }

  createUser(user: User): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}`, user);
  }
}

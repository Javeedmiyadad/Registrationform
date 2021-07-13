import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl = 'https://localhost:5001/api/User/post';

  constructor(private httpClient: HttpClient) { }

  // createUser(user: User): Observable<any> {
  //   return this.httpClient.post(`${this.baseUrl}`,user);
  // }
  createUser(userdata): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}`, userdata).pipe(catchError(this.handleError));
}
handleError(error: HttpErrorResponse) {
  return throwError(error);
}

}


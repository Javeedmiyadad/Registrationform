import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Departments } from '../Models/departments';
import { Designation } from '../Models/designation';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class FormService {

  private deptUrl = 'https://localhost:5001/api/User/get';
  private designUrl = 'https://localhost:5001/api/User/getbydeptid';


  constructor(private httpClient: HttpClient) { }

  getDepartments(): Observable<Departments[]> {

    return this.httpClient.get<Departments[]>(`${this.deptUrl}`
    );
  }
  getDesignations(id): Observable<Designation[]> {

    // search url
    // const searchDesignationUrl = `${this.designUrl}/${id}`;

    return this.httpClient.get<Designation[]>(`${this.designUrl}/${id}`);
  }

}

interface GetResponseDesignations {
  _embedded: {
    designations: Designation[];
  }
}

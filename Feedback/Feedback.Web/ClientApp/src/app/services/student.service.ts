import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StudentInfo } from '../models/student';

@Injectable()
export class StudentService {
  constructor(private _http:HttpClient) { 

  }
  getData()
  {
   return this._http.get<StudentInfo[]>("student");
  }

}

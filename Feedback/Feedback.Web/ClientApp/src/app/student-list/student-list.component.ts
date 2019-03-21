import { Component, OnInit } from '@angular/core';
import { StudentService } from '../services/student.service';
import { StudentInfo } from '../models/student';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
 students:StudentInfo[];
  constructor(private _studentService:StudentService) { 

     this._studentService.getData().subscribe(resp=>{
       this.students=resp;
     });
  }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';
import { MyService } from '../services/myservice';
import { RegisterModel } from '../models/registermodel.model';
import {Http, Response} from '@angular/http';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private myService: MyService) { }
  model:RegisterModel=new RegisterModel()

  ngOnInit() {
  }
  register(){
    this.myService.register(this.model).subscribe(
      res => {console.log(res)})
  }
}

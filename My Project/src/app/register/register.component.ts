import { Component, OnInit } from '@angular/core';
import {FormsModule } from '@angular/forms';
import { RegisterModel } from '../../models/registermodel.model';
 
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model:RegisterModel=new RegisterModel()
  constructor() { }

  ngOnInit() {
  }
  register(){
    // this.  sampleservice.getSampleApi().subscribe(
    //   res => {
    //     this.res = res
    //     console.log(res)
  }
}

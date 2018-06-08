import { Component, OnInit } from '@angular/core';
import {FormsModule } from '@angular/forms';
import { RegisterModel } from '../../models/registermodel.model';
import { SampleService } from '../../services/sample.service';

 
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  // model:RegisterModel=new RegisterModel()
  res:any
  constructor(private sampleService: SampleService) { }

  ngOnInit() {
  }
  register(){
    this.sampleService.getSampleApi().subscribe(
      res => {
        this.res = res
        console.log(res)
      })
  }
}

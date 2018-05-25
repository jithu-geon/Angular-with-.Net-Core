import { Component } from '@angular/core'
import { SampleService } from '../services/sample.service';
import { SampleModel } from '../models/sample.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers:[SampleService]
})
export class AppComponent {
  constructor(private sampleservice: SampleService){}
  res :any
  model:SampleModel=new SampleModel()
  ngOnInit() {
  }
    callSampleApi(){
    this.sampleservice.getSampleApi().subscribe(
      res => {
        this.res = res
        console.log(res)
      },
    err=>
    {console.log(err)}
   )
  }

  
  postApi(){
    this.model.name='jithu';
    this.model.age=24;
     this.sampleservice.postSampleApi(this.model).subscribe(
       model=>{console.log(model);}
     );
  }
}

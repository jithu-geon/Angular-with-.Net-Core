import { Component, OnInit } from '@angular/core';
import { MyService } from './services/myservice';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  greetings = '';

  constructor(private _appService: MyService) { }

  ngOnInit(): void {
    this._appService.sayHello()
      .subscribe(
      result => {
        this.greetings = result;
      }
      );
  }
}
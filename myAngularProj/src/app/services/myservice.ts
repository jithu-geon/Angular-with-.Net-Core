import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';

// Import RxJs required methods
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class MyService {
    private serviceUrl = 'api/Register';

    // Resolve HTTP using the constructor
    constructor(private http: Http) { }

    sayHello(): Observable<any> {
        return this.http.get(this.serviceUrl).map((response: Response) => {
            return response.text();
        });
    }
    register(model) {
       
         return this.http.post(`${this.serviceUrl}`,model );
       }
    }
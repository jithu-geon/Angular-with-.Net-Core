import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class SampleService {
  // private instance variable to hold base url
  private serviceUrl = 'http://localhost:54705/api/MyProject';

  constructor(private http: HttpClient) { }

  getSampleApi(){
    return this.http.get<any>(`${this.serviceUrl}`);
  }
  postSampleApi(model) {
   // let content = JSON.stringify(data);
    return this.http.post<any>(`${this.serviceUrl}`,model );
  }
}
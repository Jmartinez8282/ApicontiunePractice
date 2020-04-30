import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class DataService {
url= 'localhost:5000/streaming'
  constructor(private http:HttpClient) { }

  GetTracks(){
    return this.http.get(this.url);
  }
}

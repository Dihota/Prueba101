import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Property } from '../Models/property';

@Injectable({
  providedIn: 'root'
})
export class ProperService {
  list?: Property[];

  constructor(private  http:HttpClient) { }

  ReadProperty(){
    return this.http.get("https://localhost:7059/api/Propertys").toPromise()
    .then(data =>{
      this.list = data as Property[];
    });
  }

  ReadPropertyFilter(fil: string){
    return this.http.get("https://localhost:7059/api/Propertys/Filter?city=" + fil).toPromise()
    .then(data =>{
      this.list = data as Property[];
    });
  }


}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Owner } from '../Models/owner';
import { Property } from '../Models/property';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  list?: Owner[];
 
  constructor( private http: HttpClient) { }

  AddOwner(own: Owner){
    return this.http.post<Owner>("https://localhost:7243/api/Empleadoes", own)
  }

  ReadOwner(){
    return this.http.get("https://localhost:7059/api/Owners").toPromise()
    .then(data =>{
      this.list = data as Owner[];
    });
  }
}

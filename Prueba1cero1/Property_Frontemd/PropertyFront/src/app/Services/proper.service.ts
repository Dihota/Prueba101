import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Property } from '../Models/property';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProperService {
  list?: Property[];
  private UpdateForm = new BehaviorSubject<Property>({} as any);

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

  update(proper: Property){
    this.UpdateForm.next(proper);
  }

  getproperty(): Observable<Property>{
    return this.UpdateForm.asObservable();
  }

}

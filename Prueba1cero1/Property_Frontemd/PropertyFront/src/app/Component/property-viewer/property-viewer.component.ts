import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Property } from 'src/app/Models/property';
import { ProperService } from 'src/app/Services/proper.service';

@Component({
  selector: 'app-property-viewer',
  templateUrl: './property-viewer.component.html',
  styleUrls: ['./property-viewer.component.css']
})
export class PropertyViewerComponent implements OnInit, OnDestroy {
  suscription: Subscription;
  proper: Property;
  id = 0;
  img = '';
  name='';
  codint = 0;
  propietario = '';
  dir='';
  precio='';


  constructor( public properservi: ProperService ) { }

  ngOnInit(): void { 
     this.suscription = this.properservi.getproperty().subscribe(data =>{
      console.log(data);
      this.proper = data;
      this.img = this.proper.img;
      this.name = this.proper.name;
      this.codint = this.proper.codeInternal;
      this.propietario = this.proper.nameOwner;
      this.dir = this.proper.address;
      this.precio = this.proper.price;
      console.log(this.proper.img);
    });
  }

  ngOnDestroy(){
    this.suscription.unsubscribe();
  }
}

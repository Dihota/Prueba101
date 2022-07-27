import { Component, OnInit } from '@angular/core';
import { Property } from 'src/app/Models/property';
import { ProperService } from '../../Services/proper.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  fil = '';
  texto = '≡';
  constructor( public properservis : ProperService) { }

  ngOnInit(): void {
    this.properservis.ReadProperty();
  }
  
  getFilter(){
    this.properservis.ReadPropertyFilter(this.fil);
    
    if (this.fil != '') {
      this.texto= '≠'
    }
    else{
      this.texto= '≡'
    }

    this.fil = '';
  }

  Mostrar(prop : Property){
      this.properservis.update(prop);
  }
}

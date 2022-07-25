import { Component, OnInit } from '@angular/core';
import { Owner } from '../../Models/owner';
import { PropertyService } from '../../Services/property.service';

@Component({
  selector: 'app-owner',
  templateUrl: './owner.component.html',
  styleUrls: ['./owner.component.css']
})
export class OwnerComponent implements OnInit {

  constructor( public propertyService: PropertyService) { }

  ngOnInit(): void {
    this.propertyService.ReadOwner();
  }

}

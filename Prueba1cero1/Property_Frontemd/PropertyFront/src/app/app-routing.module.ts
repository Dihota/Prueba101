import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Component/home/home.component';
import { ViewPropertyComponent } from './Component/home/view-property/view-property.component';
import { OwnerComponent } from './Component/owner/owner.component';
import { PropertyViewerComponent } from './Component/property-viewer/property-viewer.component';


const routes: Routes = [
  { path:'', component: HomeComponent},
  { path:'owner', component:OwnerComponent},
  { path: 'viewProper' , component:PropertyViewerComponent},
  { path: 'add', component:ViewPropertyComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

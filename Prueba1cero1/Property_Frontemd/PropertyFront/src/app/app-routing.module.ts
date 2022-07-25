import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Component/home/home.component';
import { OwnerComponent } from './Component/owner/owner.component';
import { PropertyViewerComponent } from './Component/property-viewer/property-viewer.component';


const routes: Routes = [
  { path:'', component: HomeComponent},
  { path:'owner', component:OwnerComponent},
  { path: 'view' , component:PropertyViewerComponent}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

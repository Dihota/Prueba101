import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavComponent } from './Component/nav/nav.component';
import { HomeComponent } from './Component/home/home.component';
import { OwnerComponent } from './Component/owner/owner.component';
import { HttpClientModule} from '@angular/common/http'
import { FormsModule } from '@angular/forms';
import { PropertyViewerComponent } from './Component/property-viewer/property-viewer.component';
import { ViewPropertyComponent } from './Component/home/view-property/view-property.component';






@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    OwnerComponent,
    PropertyViewerComponent,
    ViewPropertyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

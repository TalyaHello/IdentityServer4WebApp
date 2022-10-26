import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ApiAuthorizationModule } from './api-authorization/api-authorization.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataComponent } from './data/data.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [AppComponent, DataComponent, HomeComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    ApiAuthorizationModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

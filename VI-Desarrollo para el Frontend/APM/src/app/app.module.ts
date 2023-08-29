import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { WelcomeComponent } from './home/welcome.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MonedasComponent } from './Monedas/monedas.component';

@NgModule({
  declarations: [
    AppComponent, 
    WelcomeComponent,
    MonedasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent, WelcomeComponent,MonedasComponent]
})
export class AppModule { }

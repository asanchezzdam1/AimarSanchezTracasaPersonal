import { Component } from '@angular/core';

@Component({
  selector: 'pm-monedas',
  template: ` <div class="container">
    <div class="card-deck"  *ngFor="let moneda of monedas">
      <div class="card col-3 m-3">
        <div class="card-body">
          <h5 class="card-title">{{ moneda }}</h5>
          <p class="card-text">Informacion sobre {{ moneda }}</p>
          <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
      </div>
    </div>
  </div>`,
})
export class MonedasComponent {
  monedas: string[] = ['EUR', 'USD', 'JPY', 'GBP'];
}

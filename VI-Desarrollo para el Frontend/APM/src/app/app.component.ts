import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  template: `<div>
    <h1>{{pagetitle}}</h1>
    <p>
      Mi primer Component
    </p>
    <pm-welcome></pm-welcome>
    <pm-monedas></pm-monedas>
  </div>`
})
export class AppComponent {
  pagetitle = 'apm';
}

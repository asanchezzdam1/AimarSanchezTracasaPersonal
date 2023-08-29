import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  template: `<div>
    <h1>{{pagetitle}}</h1>
    <p>
      Mi primer Component
    </p>
  </div>`
})
export class AppComponent {
  pagetitle = 'apm';
}

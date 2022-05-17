import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'pagetwo',
  templateUrl: './pagetwo.component.html',
  styleUrls: ['./pagetwo.component.scss']
})
export class PagetwoComponent {
  constructor(private router: Router){}
    goHome(){

        this.router.navigate(['/']);
    }
}

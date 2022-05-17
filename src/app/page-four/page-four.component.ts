import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-page-four',
  templateUrl: './page-four.component.html',
  styleUrls: ['./page-four.component.scss']
})
export class PageFourComponent {

  constructor(private router: Router){}
    goHome(){

        this.router.navigate(['/']);
    }

}

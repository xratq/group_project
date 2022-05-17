import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-pagethree',
  templateUrl: './pagethree.component.html',
  styleUrls: ['./pagethree.component.scss']
})
export class PagethreeComponent  {

  constructor(private router: Router){}
    goHome(){

        this.router.navigate(['/']);
    }

}

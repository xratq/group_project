import { Component} from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'fork',
  templateUrl: './fork.component.html',
  styleUrls: ['./fork.component.scss']
})
export class ForkComponent{
  constructor(private router: Router){}
    goHome(){

        this.router.navigate(['/']);
    }
}

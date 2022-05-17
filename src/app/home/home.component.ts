import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  constructor(private router: Router){}
    korp1(){

        this.router.navigate(['/korp1']);

    }
    korp2(){

        this.router.navigate(['/korp2']);

    }
    korp3(){

        this.router.navigate(['/korp3']);

    }
    korp4(){

        this.router.navigate(['/korp4']);

    }
}

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {Routes, RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { ForkComponent } from './fork/fork.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { HomeComponent } from './home/home.component';
import { PagetwoComponent } from './pagetwo/pagetwo.component';
import { PagethreeComponent } from './pagethree/pagethree.component';
import { PageFourComponent } from './page-four/page-four.component';
const appRoutes: Routes =[
    { path: '', component: HomeComponent},
    { path: 'korp1', component: ForkComponent },
    { path: 'korp2', component: PagetwoComponent },
    { path: 'korp3', component: PagethreeComponent },
    { path: 'korp4', component: PageFourComponent },
    { path: '**', component: NotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ForkComponent,
    NotFoundComponent,
    HomeComponent,
    PagetwoComponent,
    PagethreeComponent,
    PageFourComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

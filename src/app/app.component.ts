import { Component} from '@angular/core';
import {Router} from '@angular/router';

@Component({
    selector: 'my-app',
    template: `
    <div data-bs-spy="scroll" data-bs-target="#navbar-example2" data-bs-offset="0" class="scrollspy-example" tabindex="0" style="padding-left: 10px">
      <h4 id="scrollspyHeading1">Главное</h4>
      <p>Этот сайт разработан для просмотра и отслеживания......</p>
      <h4 id="scrollspyHeading2">Что можно здесь увидеть</h4>
      <p>Чем оснащены корпусы пгту политехов......</p>
      <h4 id="scrollspyHeading3">Приемущество</h4>
      <p>Удобства использования и тд</p>
      <h4 id="scrollspyHeading4">Очень умная фигня</h4>
      <p>Каждый человек Hasky</p>
      <h4 id="scrollspyHeading5">Заключение</h4>
      <p>Сайт предназначен...................</p>
    </div>

    <div class="card-group">
    <div class="card" style="width: 23rem;">
      <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="/assets/1231.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/123.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/199.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
      </div>

    </div>
      <div class="card-body">
        <h5 class="card-title">Корпус №1</h5>
        <p class="card-text">Федеральное государственное бюджетное образовательное учреждение высшего образования «Поволжский государственный технологический университет».</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">Дата образования: 5 июня 1932 года</li>
      </ul>
      <div class="card-body">
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Ссылки</a></button>
        <button type="button" class="btn btn-secondary"><a href="korp1.html" routerLink="korp1.html" class="card-link" style="text-decoration: none; color:#fff">Подробности</a></button>
      </div>
    </div>

    <div class="card" style="width: 23rem;">

      <div id="carouselExampleIndicators1" class="carousel slide" data-bs-ride="carousel">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators1" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators1" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators1" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="/assets/2.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/21.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/222.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
      </div>

    </div>
      <div class="card-body">
        <h5 class="card-title">Корпус №2</h5>
        <p class="card-text">Федеральное государственное бюджетное образовательное учреждение высшего образования «Поволжский государственный технологический университет, корпус №2»</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">Дата образования: 1955 год</li>
      </ul>
      <div class="card-body">
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Ссылки</a></button>
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Подробности</a></button>
      </div>
    </div>
    <div class="card" style="width: 23rem;">
      <div id="carouselExampleIndicators2" class="carousel slide" data-bs-ride="carousel">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators2" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators2" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators2" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="/assets/31.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/32.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/33.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
      </div>

    </div>
      <div class="card-body">
        <h5 class="card-title">Корпус №3</h5>
        <p class="card-text">Федеральное государственное бюджетное образовательное учреждение высшего образования «Поволжский государственный технологический университет, корпус №3.</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">Дата образования: 19 февраля 1899 года</li>
      </ul>
      <div class="card-body">
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Ссылки</a></button>
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Подробности</a></button>
      </div>
    </div>
    <div class="card" style="width: 23rem;">
      <div id="carouselExampleIndicators3" class="carousel slide" data-bs-ride="carousel">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators3" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators3" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators3" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="/assets/41.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/42.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
        <div class="carousel-item">
          <img src="/assets/43.jpg" class="d-block w-30 "style="height:250px" alt="...">
        </div>
      </div>

    </div>
      <div class="card-body">
        <h5 class="card-title">Корпус №4</h5>
        <p class="card-text">Федеральное государственное бюджетное образовательное учреждение высшего образования «Поволжский государственный технологический университет, корпус №4.</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">Дата образования: 5 июня 1932 года</li>
      </ul>
      <div class="card-body">
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Ссылки</a></button>
        <button type="button" class="btn btn-secondary"><a href="#" class="card-link" style="text-decoration: none; color:#fff">Подробности</a></button>
      </div>
    </div>
    </div>
            <router-outlet></router-outlet>`
})
export class AppComponent {}

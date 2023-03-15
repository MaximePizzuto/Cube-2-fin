import { Component, OnInit } from '@angular/core';
import { MeteoService } from '../services/meteo.service';

@Component({
  selector: 'app-pagedonnees',
  templateUrl: './pagedonnees.component.html',
  styleUrls: ['./pagedonnees.component.css']
})
export class PagedonneesComponent implements OnInit {

  temperature = 0;
  pression = 0;
  humidite = 0;
  datetime?: Date;

  constructor(private meteoService: MeteoService) { }

  ngOnInit(): void {

    this.getWheather();

    const interv = setInterval(() => {
      this.getWheather();
    }, 3000);
  }

  getWheather(): void {
    this.meteoService.getMeteo(1).subscribe((res) => {
      this.temperature = res.temperature;
      this.pression = res.pression;
      this.humidite = res.humidite;
      this.datetime = res.createAt ? new Date(res.createAt) : undefined;
    });
  }



}

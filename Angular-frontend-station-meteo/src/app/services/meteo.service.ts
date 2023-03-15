import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environnements/environnement';
import { map, Observable } from 'rxjs';
import { Sonde } from '../models/sonde.model';
import { Meteo } from '../models/meteo.model';

@Injectable({
    providedIn: 'root'
})

export class MeteoService {
    constructor (private http: HttpClient) {}
/**
 * 
 * @param id 
 * @returns 
 */
    getSonde(id: string | number): Observable<Sonde> {

        const url =`${environment.settings.apiUrl}/sonde/${id}`;

        return this.http.get<Sonde>(url).pipe(
            map(response => response)
        );
    }

    getMeteo(id: string | number): Observable<Meteo> {

        const url =`${environment.settings.apiUrl}/meteo/${id}`;

        return this.http.get<Meteo>(url).pipe(
            map(response => response)
        );
    }
}
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PageaccueilComponent } from './pageaccueil/pageaccueil.component';
import { PagedonneesComponent } from './pagedonnees/pagedonnees.component';
import { PagegraphiqueComponent } from './pagegraphique/pagegraphique.component';
import { LienpageaccueilComponent } from './lienpageaccueil/lienpageaccueil.component';

@NgModule({
  declarations: [
    AppComponent,
    PageaccueilComponent,
    PagedonneesComponent,
    PagegraphiqueComponent,
    LienpageaccueilComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

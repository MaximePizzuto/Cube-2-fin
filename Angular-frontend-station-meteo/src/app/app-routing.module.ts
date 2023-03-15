import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageaccueilComponent } from './pageaccueil/pageaccueil.component';
import { PagedonneesComponent } from './pagedonnees/pagedonnees.component';
import { PagegraphiqueComponent } from './pagegraphique/pagegraphique.component';

const routes: Routes = [
  { path: '', redirectTo: 'page', pathMatch: 'full' },
  { path: 'page', component: PageaccueilComponent},
  { path: 'donnees', component: PagedonneesComponent},
  { path: 'graphique', component: PagegraphiqueComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

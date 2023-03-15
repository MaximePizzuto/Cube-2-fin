import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardComponent } from 'src/card/card.component';
import { FooterComponent } from 'src/footer/footer.component';
import { HeaderComponent } from 'src/header/header.component';
import { TableauComponent } from 'src/tableau/tableau.component';
import { AccComponent } from '../acc/acc.component';
import {DashboardComponent} from '../dashboard/dashboard.component';


const routes: Routes = [

{ path: '', redirectTo:'acc', pathMatch: 'full'},
{ path: 'acc',component:  AccComponent},
{ path: 'dashboard', component: DashboardComponent},
{ path: 'header', component: HeaderComponent},
{ path: 'Footer', component: FooterComponent},
{ path: 'card', component: CardComponent},
{ path: 'tableau', component: TableauComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    initialNavigation: 'enabledBlocking'
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }

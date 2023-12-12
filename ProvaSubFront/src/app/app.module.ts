import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarComponent } from './Aluno/cadastrar/cadastrar.component';
import { ListarComponent } from './Aluno/listar/listar.component';


@NgModule({
  declarations: [
    AppComponent,
    CadastrarComponent,
    ListarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

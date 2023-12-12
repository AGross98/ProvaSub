import { Component } from '@angular/core';
import { CadastrarComponent } from './Aluno/cadastrar/cadastrar.component';

@Component({
  selector: 'app-root',
  template: `
  <a routerLink="/aluno/listar">aluno listar</a>
    <router-outlet></router-outlet>
  `,
  styles: [  ]
})
export class AppComponent {
  title = 'ProvaSubFront';
}

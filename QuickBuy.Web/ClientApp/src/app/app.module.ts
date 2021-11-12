import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
/*import { TruncateModule } from 'ng2-truncate';*/

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ProdutoComponent } from './produto/produto.component'
import { LoginComponent } from './usuario/login/login.Component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
//import { UsuarioServico } from './servicos/usuario/usuario.servico';
//import { CadastroUsuarioComponent } from './usuario/cadastro/cadastro.usuario.component';
//import { ProdutoServico } from './servicos/produto/produto.servico';
/*import { PesquisaProdutoComponent } from './produto/pesquisa/pesquisa.produto.component';*/
//import { LojaPesquisaComponent } from './loja/pesquisa/loja.pesquisa.component';
//import { LojaProdutoComponent } from './loja/produto/loja.produto.component';
//import { LojaEfetivarComponent } from './loja/efetivar/loja.efetivar.component';
//import { PedidoServico } from './servicos/pedido/pedido.servico';
//import { LojaCompraRealizadaComponent } from './loja/efetivar/loja.compra.realizada.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ProdutoComponent,
        LoginComponent
//    PesquisaProdutoComponent
   // CadastroUsuarioComponent,
        //LojaPesquisaComponent,
        //LojaProdutoComponent,
        //LojaEfetivarComponent,
        //LojaCompraRealizadaComponent

    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
          { path: '', component: HomeComponent, pathMatch: 'full' },
          { path: 'produto', component: ProdutoComponent, canActivate: [GuardaRotas] },
          { path: 'entrar', component: LoginComponent }
        ])
    ],
/*    providers: [UsuarioServico, ProdutoServico, PedidoServico],*/
    bootstrap: [AppComponent]
})
export class AppModule { }


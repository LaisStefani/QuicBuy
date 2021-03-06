import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Usuario } from '../../modelo/usuario';
import { UsuarioServico } from '../../servicos/usuario/usuario.servico';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public usuario;
  public usuarioAutenticado: boolean;
  public email: string;
  public returnUrl:string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {


  }
    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario;
    }


  entrar() {
    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      data => {

      },
      err => {

      }
    );
  }

}

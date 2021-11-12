import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Usuario } from '../../modelo/usuario';

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

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {


  }
    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario;
    }


  entrar() {

    if (this.usuario.email == "laiss988@gmail.com" && this.usuario.senha == "laiss988@gmail.com") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
  }

}

import { Component } from '@angular/core';
import { Usuario } from '../../modelo/usuario';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class Logincomponent {

  public usuario = new Usuario();
  public usuarioAutenticado: boolean;
  public email;

  entrar() {

    if (this.usuario.email== "A" && this.usuario.senha== "A") {
      this.usuarioAutenticado = true;
    }
  }

}

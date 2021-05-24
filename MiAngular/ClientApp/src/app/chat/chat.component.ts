import { Component } from '@angular/core';

@Component({
  selector: 'chat-app',
  templateUrl: 'chat.component.html'
})

export class ChatComponent {
  public nombre = 'Víctor Mtz'

  public cambiarNombre() {
    this.nombre = "Víktor Martínez 84"
  }

  public listaDeMensajes: string[] = [
    "Hola mundo",
    "core5",
    "angular"
  ];
}

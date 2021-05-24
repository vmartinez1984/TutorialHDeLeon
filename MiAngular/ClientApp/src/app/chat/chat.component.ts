import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ChatService } from '../service/chat.service';
import { Message } from '../Interfaces';

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

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string, protected chatService: ChatService) {
   
  }

  public getInfo() {
    this.listaDeMensajes = this.chatService.getAll();
  }
}

import { Injectable, Inject } from '@angular/core';
import { Message } from '../Interfaces';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class ChatService {
  public algo: string = "hola mundo";
  baseUrl: string;

  constructor(@Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public getAll() {
    let http: HttpClient;

    return http.get<Message[]>(this.baseUrl + "Api/Chat/Message");
  }
}

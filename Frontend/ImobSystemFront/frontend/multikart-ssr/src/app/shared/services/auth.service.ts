import { Injectable } from '@angular/core';
import { User } from '../classes/user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private loggedInUser: User | null = null;

  login(username: string, password: string): boolean {
    // Simule a autenticação, verifique se o usuário e senha correspondem
    if (username === 'facilita' && password === '123456') {
      this.loggedInUser = new User(username, password);
      return true;
    }
    return false;
  }

  isLoggedIn(): boolean {
    return this.loggedInUser !== null;
  }

  logout(): void {
    this.loggedInUser = null;
  }
}

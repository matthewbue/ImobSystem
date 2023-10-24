import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/shared/services/auth.service'; 

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  username: string = '';
  password: string = '';
  errorMessage: string = '';

  constructor(private authService: AuthService,
    private router: Router) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    if (this.authService.login(this.username, this.password)) {
      this.errorMessage = '';
      this.router.navigate(['/pages/manager']); 
    } else {
      this.errorMessage = 'Usuário ou senha incorretos';
    }
  }
}

import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { LoginService } from '../service/login.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private loginService:LoginService) { }
  invalidlogin=true;
  loggedIn$:Subscription;
  ngOnInit(): void {
    //this.invalidLogin=this.loginService.getInvalidLogin();
    this.loggedIn$=this.loginService.isLoggedIn.subscribe(
      value=>this.invalidlogin=!value
    );
  }
 
logout(){
  this.loginService.logout();
}

}

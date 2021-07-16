import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";

@Injectable({
    providedIn: 'root' // ADDED providedIn root here.
  })
export class Authguard implements CanActivate {

    constructor(private jwtHelper: JwtHelperService, private router: Router) {
    }
    canActivate() {
      const token = localStorage.getItem("jwt");
  
      if (token && !this.jwtHelper.isTokenExpired(token)){
          this.jwtHelper.decodeToken(token)
          //console.log(this.jwtHelper.decodeToken(token));
        return true;
      }
      this.router.navigate(["/login"]);
      return false;
    }
}

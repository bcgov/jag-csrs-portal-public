import { AfterViewInit, Component, OnInit, ViewEncapsulation, isDevMode } from '@angular/core';
import { Inject } from '@angular/core';
import { LoggerService } from '@core/services/logger.service';

import { Router, ActivatedRoute } from '@angular/router';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { AppConfigService } from 'app/services/app-config.service';
import { SnowplowService } from '@core/services/snowplow.service';
import { environment } from './../../../environments/environment';
import { LogInOutService } from 'app/services/log-in-out.service';
@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class LandingComponent implements OnInit
{

  public isLoggedIn = false;
  public bceIdLink: string;
  public bceIdRegisterLink: string;
  public cscLink: string;
  public welcomeUser: string;
  public code: string;

  constructor(public oidcSecurityService : OidcSecurityService,
              private logInOutService : LogInOutService,
              @Inject(LoggerService) private logger,
              @Inject(Router) private router,
              @Inject(ActivatedRoute) private route,
              @Inject(AppConfigService) private appConfigService,
              @Inject(SnowplowService) private snowplow) {
  }

  public async ngOnInit() {

      this.cscLink = this.appConfigService.cscLink;

      if(isDevMode())
      {
        this.bceIdRegisterLink = this.appConfigService.appConfig.bceIdRegisterLink;
      }
      else
      {
        this.bceIdRegisterLink = this.appConfigService.appConfig.bceIdRegisterLink_P;
      }
      this.logger.info('isDevMode :',isDevMode());
      this.logger.info('bceIdRegisterLink :',this.bceIdRegisterLink);

      this.logInOutService.getLogoutStatus.subscribe((data) => {
        if (data !== null || data !== '')
        {
          if(data === 'BCeID Login'){
            this.login();
          }
          else
            if(data === 'Logout'){
              this.logout();
            }
        }
      })

      this.oidcSecurityService.checkAuth().subscribe(({ isAuthenticated,
                                          userData,
                                          accessToken,
                                          idToken,
                                          configId,
  errorMessage }) => {
          this.logger.info('isAuthenticated: ', isAuthenticated);
          this.logger.info('userData: ', userData);
          this.logger.info('accessToken: ', accessToken);
          this.logger.info('idToken: ', idToken);
          this.logger.info('configId: ', configId);
          this.logger.info('errorMessage: ', errorMessage);

          if (isAuthenticated === true)
          {
            this.router.navigate(['/welcomeuser']);
          }
          else
          {
            this.router.navigate(['/']);
          }

          this.logInOutService.currentUser(isAuthenticated);
      });


    }

  login() {
      this.oidcSecurityService.authorize();
  }

  logout() {
      this.oidcSecurityService.logoffAndRevokeTokens();
  }

  public ngAfterViewInit(): void {
    this.snowplow.refreshLinkClickTracking();
  }
}

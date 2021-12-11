import { Component, OnInit, isDevMode } from '@angular/core';
import { Router, NavigationEnd, RouterEvent } from '@angular/router';
import { Meta, Title } from '@angular/platform-browser';
import { ConfigService } from '@config/config.service';
import { RouteStateService } from '@core/services/route-state.service';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { LoggerService } from '@core/services/logger.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
   env = environment;
  constructor(
    private routeStateService: RouteStateService,
    private titleService: Title,
    private configService: ConfigService,
    private metaTagService: Meta,
    private router: Router,
    private logger: LoggerService,

  ) {

    this.router.events.subscribe((evt) => {
      if (evt instanceof NavigationEnd) {

      }
    });
  }

  ngOnInit() {
    if (isDevMode()) {
      this.logger.log('info', 'Development!')
    } else {
      this.logger.log('info', 'Production!')
    }
  }



}

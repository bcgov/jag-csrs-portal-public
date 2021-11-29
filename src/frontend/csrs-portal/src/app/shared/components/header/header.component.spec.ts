import {
  ComponentFixture,
  fakeAsync,
  flush,
  TestBed,
} from '@angular/core/testing';
import { CoreModule } from '@core/core.module';
import { LoggerService } from '@core/services/logger.service';
import { NgxMaterialModule } from '@shared/modules/ngx-material/ngx-material.module';
import { NgxProgressModule } from '@shared/modules/ngx-progress/ngx-progress.module';
import { AuthService } from 'app/services/auth.service';
import { EMPTY } from 'rxjs';
import { MockAuthService } from 'tests/mocks/mock-auth.service';
import { HeaderComponent } from './header.component';



describe('HeaderComponent', () => {
  let component: HeaderComponent;
  let fixture: ComponentFixture<HeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NgxMaterialModule, NgxProgressModule, CoreModule],
      declarations: [HeaderComponent],
      providers: [
        HeaderComponent,
        { provide: AuthService, useClass: MockAuthService },
        LoggerService,
      ],
    })
      .compileComponents()
      .then(() => {
        fixture = TestBed.createComponent(HeaderComponent);
      });

    component = TestBed.inject(HeaderComponent);
  });

});

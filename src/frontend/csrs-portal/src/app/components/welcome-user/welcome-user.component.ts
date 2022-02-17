import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
  FormArray,
} from '@angular/forms';
import { AccountService } from 'app/api/api/account.service';
import { LoggerService } from '@core/services/logger.service';
import { Inject} from '@angular/core';
import { HttpClient, HttpStatusCode, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { AppRoutes } from 'app/app.routes';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { List, Dictionary } from 'ts-generic-collections-linq';
import { ModalDialogComponent } from 'app/components/modal-dialog/modal-dialog.component';

// -- import data structure
import {
  NewFileRequest,
  CSRSAccount,
  ModelFile,
  FileStatus,
} from 'app/api/model/models';

@Component({
  selector: 'app-welcome-user',
  templateUrl: './welcome-user.component.html',
  styleUrls: ['./welcome-user.component.scss']
})
export class WelcomeUserComponent implements OnInit {

  accountFormGroup: FormGroup;
  csrsAccount: CSRSAccount = null;
  data: any = null;
  outData: NewFileRequest = null;

  constructor(private _formBuilder: FormBuilder, private http: HttpClient,
              @Inject(AccountService) private accountService,
              @Inject(LoggerService) private logger,
              @Inject(Router) private router,
              @Inject(OidcSecurityService) private oidc,
              public dialog: MatDialog,
              private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.accountFormGroup = this._formBuilder.group({
      fileNumber: ['', Validators.required],
      password: ['', Validators.required]
    });
    this.accountService.apiAccountGet().subscribe({
      next: (data:any) => {
        var user   = data.user;
        var files  = data.files;

        if (user != null && files != null && files.length > 0)
        {
          const listFiles = new List<ModelFile>(files); this.logger.info("listFiles", listFiles);
          const activeStatus:ModelFile = listFiles.firstOrDefault(x=>x.status == FileStatus.Active);
          this.logger.info("activeStatus", activeStatus);

          if (activeStatus)
          {
            this.logger.info("redirect to Communication");
            this.router.routeReuseStrategy.shouldReuseRoute = () => false;
            this.router.navigate(['/communication']);
          }
        }
      },
      error: (e) => {
        if (e.error instanceof Error) {
          this.logger.error(e.error.message);
        } else {
            //Backend returns unsuccessful response codes such as: 500 etc.
            this.logger.info('Backend returned ', e);
          }
      },
      complete: () => {
      }
    })
  }

  openModalDialog(): void {
    const dialogRef = this.dialog.open(ModalDialogComponent, {
      width: '450px',
      data: this.data,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.logger.info(`Dialog result: ${result}`);
    });
  }

  checkAccount(){

    this.data = {
      type: 'error',
      title: 'Technical error',
      content: 'Your account setup request could not be submitted.',
      content_normal: 'Please try again, or contact the Recalculation Service toll free',
      content_link: '1-866-660-2644',
      weight: 'bold',
      color: 'red'
    };


    /*
    return this.http.get(api.get, {headers: new HttpHeaders(
        {
          'Authorization': 'Bearer' + my_token,
           'Content-Type': 'application/json'
              })});
        }

    */

    const accountData = this.accountFormGroup.value;
    const csrsAccount: CSRSAccount = {fileNumber: accountData.fileNumber, referenceNumber: accountData.password };


    this.accountService.apiAccountCheckcsrsaccountPost(csrsAccount,
      {headers: new HttpHeaders(
        {
          'Authorization': 'Bearer' + this.oidc.getAccessToken(),
           'Content-Type': 'application/json'
        })}).subscribe({
      next: (outData:any) => {
        var partyId = outData.partyId;
        var fileId = outData.fileId;

        if (!partyId || !fileId)
        {
          this.openModalDialog();
        }
        else
          if (partyId && fileId)
          {
            this.router.navigate(['/stepperform'], { queryParams: { partyId: partyId, fileId: fileId} });
          }

      },
      error: (e) => {
        this.openModalDialog();

        if (e.error instanceof Error) {
          this.logger.error(e.error.message);
        } else {
            //Backend returns unsuccessful response codes such as 404, 500 etc.
            this.logger.info('Backend returned ', e);
        }
      },
      complete: () => this.logger.info('apiAccountCheckcsrsaccountPost is completed')
    })
  }
}

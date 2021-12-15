import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
  FormArray,
} from '@angular/forms';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { JsonPipe } from '@angular/common';
import { AccountService } from 'app/api/api/account.service';
import { LookupService } from 'app/api/api/lookup.service';
import { Inject } from '@angular/core';
import { LoggerService } from '@core/services/logger.service';

@Component({
  selector: 'app-child-application-question',
  templateUrl: './child-application-question.component.html',
  styleUrls: ['./child-application-question.component.scss'],
})
export class ChildApplicationQuestionComponent implements OnInit {
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  thirdFormGroup: FormGroup;
  fourthFormGroup;
  fourthFormGroup1: FormGroup;
  fifthFormGroup: FormGroup;
  sixFormGroup: FormGroup;
  seventhFormGroup: FormGroup;
  eFormGroup: FormGroup;
  nineFormGroup: FormGroup;
  provinceData: any = [];
  genderData: any = [];
  identityData: any = [];
  referalsData: any = [];
  courtLocationsData: any = [];
  _accountService: AccountService;
  _lookupService: LookupService;
  _logger: LoggerService;

  constructor(private _formBuilder: FormBuilder, private http: HttpClient,
    @Inject(AccountService) private accountService,
    @Inject(LookupService) private lookupService,
    @Inject(LoggerService) private logger) {}

  ngOnInit() {
    this._accountService = this.accountService;
    this._lookupService = this.lookupService;
    this._logger = this.logger;

    this.provinceData = [{label: 'province', value: 'british columbia'}];
    this.identityData = [{label: 'hai', value: ''}];
    this.genderData =  [{label: 'hai', value: 1234}];
    this.getReferalsData();
    this.getCourtLocationData();
    this.getIdentityData();
    this.getProvinceData();
    this.getGenderyData();

    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required],
      secondControl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      firstName: ['', Validators.required],
      givenNames: [''],
      lastName: ['', Validators.required],
      birthdate: ['', Validators.required],
      address1: ['', Validators.required],
      city: ['', Validators.required],
      province: ['', Validators.required],
      postalCode: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      email: ['', Validators.email],
      PreferredName: [''],
      saddress: [''],
      cellNumber: [''],
      workNumber: [''],
      gender: [''],
      identity: ['']
    });
    this.thirdFormGroup = this._formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      pname: [],
      birthdate: [],
      givenNames: [],
      saddress: [],
      sadress1: [],
      province: [],
      postalCode: [],
      phoneNumber: []
    });

    this.fourthFormGroup1 = this._formBuilder.group({
      users: this._formBuilder.array([
        this._formBuilder.group({
          firstName: [''],
          lastName: [''],
          birthdate: [],
          givenNames: [],
          middleName: []
        })

      ])
    });
    // this.fourthFormGroup = this._formBuilder.group({
    //   firstName: ['', Validators.required],
    //   lastName: ['', Validators.required],
    //   birthdate: [],
    //   givenNames: [],
    //   middleName: []
    // });
    this.fifthFormGroup = this._formBuilder.group({
      firstName: [''],
      birthdate: [],
    });
    this.sixFormGroup = this._formBuilder.group({
      // secondCtrl: ['', Validators.required],
    });
    this.seventhFormGroup = this._formBuilder.group({
      secondCtrl: [''],
    });
    this.eFormGroup = this._formBuilder.group({
      secondCtrl: [''],
    });
    this.nineFormGroup = this._formBuilder.group({
      secondCtrl: [''],
    });
    this.setFormDataFromLocal();
  }
  setFormDataFromLocal(){
  if (localStorage.getItem('formData')){
      let data = localStorage.getItem('formData');
      data = JSON.parse(data);
      if (data['firstStep']){
        this.firstFormGroup.patchValue(data['firstStep']);
      }
      if (data['secondFormGroup']){
        this.secondFormGroup.patchValue(data['secondFormGroup']);
      }
      if (data['thirdFormGroup']){
        this.thirdFormGroup.patchValue(data['thirdFormGroup']);
      }
      if (data['fourthFormGroup']){
        this.fourthFormGroup.patchValue(data['fourthFormGroup']);
      }
      if (data['fifthFormGroup']){
        this.fifthFormGroup.patchValue(data['fifthFormGroup']);
      }
      if (data['sixFormGroup']){
        this.sixFormGroup.patchValue(data['sixFormGroup']);
      }
      if (data['seventhFormGroup']){
        this.seventhFormGroup.patchValue(data['seventhFormGroup']);
      }
      if (data['eFormGroup']){
        this.eFormGroup.patchValue(data['eFormGroup']);
      }
      if (data['nineFormGroup']){
        this.nineFormGroup.patchValue(data['nineFormGroup']);
      }
  }

}
getIdentityData() {
  this._accountService.apiAccountIdentitiesGet().subscribe(data => {
      this.identityData = data;
    },
    (err: HttpErrorResponse) => {
      if (err.error instanceof Error) {
       //A client-side or network error occurred.
       this._logger.log('error',err.error.message);
      } else {
          //Backend returns unsuccessful response codes such as 404, 500 etc.
          this._logger.log('info',`Backend returned status code: ${err.status}`);
          this._logger.log('info',`Response body: ${err.error}`);
        }
     });
}

getProvinceData() {
  this._accountService.apiAccountProvincesGet().subscribe(data1 => {
    this.provinceData = data1;
  },
  (err: HttpErrorResponse) => {
    if (err.error instanceof Error) {
     //A client-side or network error occurred.
     this._logger.log('error',err.error.message);
    } else {
        //Backend returns unsuccessful response codes such as 404, 500 etc.
        this._logger.log('info',`Backend returned status code: ${err.status}`);
        this._logger.log('info',`Response body: ${err.error}`);
      }
   });
}

  getGenderyData() {
    this._accountService.apiAccountGendersGet().subscribe(data2 => {
        this.genderData =  data2;
    },
    (err: HttpErrorResponse) => {
      if (err.error instanceof Error) {
      //A client-side or network error occurred.
      this._logger.log('error',err.error.message);
      } else {
          //Backend returns unsuccessful response codes such as 404, 500 etc.
          this._logger.log('info',`Backend returned status code: ${err.status}`);
          this._logger.log('info',`Response body: ${err.error}`);
        }
    });
  }

  getCourtLocationData() {
    this._lookupService.courtlocationsGet().subscribe(data1 => {
      this.courtLocationsData = data1;
      },
      (err: HttpErrorResponse) => {
        if (err.error instanceof Error) {
        //A client-side or network error occurred.
        this._logger.log('error',err.error.message);
        } else {
            //Backend returns unsuccessful response codes such as 404, 500 etc.
            this._logger.log('info',`Backend returned status code: ${err.status}`);
            this._logger.log('info',`Response body: ${err.error}`);
          }
      });
  }

  getReferalsData() {
    this._accountService.apiAccountReferralsGet().subscribe(data1 => {
        this.referalsData = data1;
    },
    (err: HttpErrorResponse) => {
      if (err.error instanceof Error) {
      //A client-side or network error occurred.
      this._logger.log('error',err.error.message);
      } else {
          //Backend returns unsuccessful response codes such as 404, 500 etc.
          this._logger.log('info',`Backend returned status code: ${err.status}`);
          this._logger.log('info',`Response body: ${err.error}`);
        }
    });
  }

  callAntherchild(){
    const usersArray = this.fourthFormGroup1.controls.users as FormArray;
    const arraylen = usersArray.length;

    const newUsergroup: FormGroup = this._formBuilder.group({
      firstName: [''],
      lastName: [''],
      birthdate: [],
      givenNames: [],
      middleName: []
    });

    usersArray.insert(arraylen, newUsergroup);
  }

  saveLater(){
    const formData = {
      firstStep: this.firstFormGroup.value,
      secondFormGroup: this.secondFormGroup.value,
      thirdFormGroup: this.thirdFormGroup.value,
      fourthFormGroup1: this.fourthFormGroup1.value,
      fifthFormGroup: this.fifthFormGroup.value,
      sixFormGroup: this.sixFormGroup.value,
      seventhFormGroup: this.seventhFormGroup.value,
      eFormGroup: this.eFormGroup.value,
      nineFormGroup: this.nineFormGroup.value,
    };
    localStorage.setItem('formData', JSON.stringify(formData));
  }
  save(){
    localStorage.getsetItemItem('formData', '');
  }

}

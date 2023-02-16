import { Component } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  registerForm: FormGroup;

  constructor(private _formBuilder: FormBuilder) {
    this.registerForm = this._formBuilder.group({
      name: [''],
      lastName: [''],
      birthdate: [''],
      civilStatus: [''],
      hasBrothers: [''],
      state: [''],
      narolesme: [''],
    });
  }
}

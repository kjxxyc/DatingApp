import { Component, EventEmitter, Input, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  // @Input() usersFromComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {}

  constructor(private accountService: AccountService,
    private toastr: ToastrService) { }

  register() {
    // console.log(this.model);

    this.accountService.register(this.model).subscribe({
      // next: response => {
        // console.log(response);
      next: () => {
        this.cancel();
      },
      error: error => {
        this.toastr.error(error.error);
        console.log(error);
      }
    })    
  }

  cancel() {
    console.log('cancelled se ejecuta. :O');
    this.cancelRegister.emit(false);
  }
}
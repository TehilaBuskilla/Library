import { Injectable } from '@angular/core';
import { FormControl, ValidationErrors, ValidatorFn } from '@angular/forms';
import { Users } from '../class/users';
import { UsersService } from './users.service';

@Injectable({
  providedIn: 'root'
})
export class UserValidationService {

  constructor(private userService: UsersService) { }

  checkUserId(): ValidatorFn {
    return (ctrl: FormControl): ValidationErrors | null => {
      this.userService.GetAll().subscribe(a => {
        if (a.find(u => u.IdUser.trim() == ctrl.value.trim())) {
          return { 'IdUser': { exist: true } }
        }

        return null;
      })
      return null;
    }
  }
}

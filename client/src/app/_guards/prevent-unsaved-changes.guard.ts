import { CanDeactivateFn } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';

export const preventUnsavedChangesGuard: CanDeactivateFn<MemberEditComponent> = (component) => {
// IMPIDE QUE NOS SAQUE DEL FORMULARIO-NAVEGUE SI NO SE HAN GUARDADO LOS CAMBIOS
  if (component.editForm?.dirty) {

    return confirm('Are u sure u want to continue? Any unsaved changes will be lost. o.O');
  }
  return true;
};

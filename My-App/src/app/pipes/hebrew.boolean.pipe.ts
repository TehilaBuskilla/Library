import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'hebrewBoolean'
})
export class HebrewBooleanPipe implements PipeTransform {

  transform(value: boolean, reverse: boolean = false): string {
    value = reverse?!value:value;
    return value? 'כן': 'לא';
  }

}

import {Component}from '@angular/core';

@Component({
    selector: 'Footer',
    templateUrl: './footer.component.html'
})
export class Footer{
    date = new Date().getFullYear();
}
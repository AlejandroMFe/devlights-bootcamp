import { Component } from '@angular/core';


@Component({
    selector: 'Pricing',
    templateUrl: './Pricing.component.html',
    styleUrls: [ './Pricing.component.css' ],
})
export class Pricing {
    title = 'Pricing';

    classes = [ 'Basic', 'Intermediate', 'Advanced' ];
    prices = [ 1200, 1750, 3500 ];
    features = [ '1 month unlimited classes', '6 months unlimited classes', '12 months unlimited classes' ];
    description = [ 'The most affordable price and a wonderful experience', 'The most flexible price and a wonderful experience', 'The most expensive price but a more customizable experience' ];
    images = [ 'assets/images/basic.jpg', 'assets/images/intermediate.jpg', 'assets/images/advanced.jpg' ];
}
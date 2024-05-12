import { Component } from '@angular/core';
import { PageHeaderComponent } from '../page-header/page-header.component';
import { BreadcrumbComponent } from '../breadcrumb/breadcrumb.component';
import { ToolboxComponent } from '../toolbox/toolbox.component';
import { ProductSectionComponent } from '../product-section/product-section.component';
import { CategorySectionComponent } from '../category-section/category-section.component';
import { BrandSectionComponent } from '../brand-section/brand-section.component';
import { TagSectionComponent } from '../tag-section/tag-section.component';
import { PriceSectionComponent } from '../price-section/price-section.component';

@Component({
  selector: 'app-shop',
  standalone: true,
  imports: [
    PageHeaderComponent,
    BreadcrumbComponent,
    ToolboxComponent,
    ProductSectionComponent,
    CategorySectionComponent,
    BrandSectionComponent,
    TagSectionComponent,
    PriceSectionComponent
  ],
  templateUrl: './shop.component.html',
  styleUrl: './shop.component.css'
})
export class ShopComponent {

}
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Sort } from '@angular/material/sort';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  api = 'api/Product';
  constructor(private http: HttpClient) {}

  getAllProduct(filter?: string): Observable<Product[]> {
    return this.http.get<Product[]>(
      `${environment.apiEndpoint}${this.api}` +
        '/GetAll?filter=' +
        filter?.toLowerCase()
    );
  }

  // getProductByFilter(filter: string): Observable<Product[]> {
  //   return this.http.get<Product[]>(
  //     `${environment.apiEndpoint}${this.api}` +
  //       '/GetRecordsByFilterName?filter=' +
  //       filter.toLowerCase()
  //   );
  // }

  sortProducts(sort: Sort): Observable<Product[]> {
    return this.http.post<Product[]>(
      `${environment.apiEndpoint}${this.api}/sort`,
      sort
    );
  }
}

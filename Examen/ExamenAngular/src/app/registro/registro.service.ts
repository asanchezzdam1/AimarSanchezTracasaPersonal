import { HttpClient, HttpErrorResponse,HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, throwError } from "rxjs";
import { IRegistro} from "./registro";



@Injectable({
  providedIn: 'root'
})
export class RegistroService {
    //hay que moverl a un servicio de datos
  
  private getUrl = "https://localhost:7235/api/usuarios";
  private postUrl = "https://localhost:7235/api/usuarios/registro";

  constructor(private http: HttpClient) { }

  getPersonas(): Observable<IRegistro[]> {
    console.log('Making API get registros');
    return this.http.get<IRegistro[]>(this.getUrl);
  }

 
  postPersonas(registro: IRegistro): Observable<IRegistro> {
    console.log('Making API post registro');
    return this.http.post<IRegistro>(this.postUrl, registro);
  }

  private handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }

}
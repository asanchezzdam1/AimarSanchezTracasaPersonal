import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { IRegistro } from './registro';
import { RegistroService } from './registro.service';

@Component({
  selector: 'pm-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.css']
})
export class RegistroComponent implements OnInit{

    formulario: FormGroup;
    sub!: Subscription;
    sub2!: Subscription;  
    personas: IRegistro[] = [];
    nombre: string="";
    fechaNacimiento: string ="";
    telefono: string ="";
    persona!: IRegistro;
  
    constructor( private registroService: RegistroService, public fb: FormBuilder){
      this.formulario = this.fb.group({
        nombre: ['', [Validators.required]],
        fechaNacimiento: ['', [Validators.required]],
        telefono: '',
      });
    }

    ngOnInit() {
        this.getPersonas();
        
    }

    getPersonas(){
        this.sub =this.registroService.getPersonas().subscribe(
            (personas) => {
            this.personas = personas;
            },
            (error: any) =>{
                console.log("Ha habido un error:"+error)
            }
          );
    }

    rellenarRegistro(formulario: FormGroup): void {
        const registroDTO: IRegistro = {
          nombre: formulario.value.nombre,
          fechaNacimiento: formulario.value.fechaNacimiento,
          telefono: formulario.value.telefono
        };
        console.log("estoy pidiendo el registro");
        this.hacerRegistro(registroDTO);
      }
    
      //Realiza el POST enviando el registro rellenado
      hacerRegistro(registroDTO: IRegistro): void {
        this.registroService.postPersonas(registroDTO).subscribe(
            (persona) => {// Asigna las monedas recuperadas
                 this.getPersonas();
              }
        );
      }  
        
         
      ngOnDestroy(): void {
        if (this.sub) {
          this.sub.unsubscribe();
        }
        if (this.sub2) {
          this.sub2.unsubscribe();
        }
      }

}




import { Component } from '@angular/core';
import { UsuarioService } from '../services/usuario.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent {
  nuevoUsuario: any = { nombre: '', telefono: '', fechaNacimiento: '' };

  constructor(private usuarioService: UsuarioService) {}

  onSubmit(event: Event): void {
    event.preventDefault();
    this.usuarioService.registrarUsuario(this.nuevoUsuario).subscribe(
      response => {
        console.log('Usuario registrado:', response);
        setTimeout(() => {
          location.reload();
        }, 500); // Recargar la página después de 500 ms
      },
      error => console.error('Error al registrar usuario', error)
    );
  }
}

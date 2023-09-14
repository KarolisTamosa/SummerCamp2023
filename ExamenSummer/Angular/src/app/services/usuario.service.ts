import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UsuarioAltaDto } from 'src/app/dto/usuarioaltadto';
import { UsuarioVerDto } from 'src/app/dto/usuarioverdto';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  private apiUrl = 'https://localhost:7299/api'; // Reemplaza con la URL de tu API

  constructor(private http: HttpClient) {}

  getUsuarios(): Observable<UsuarioVerDto[]> {
    return this.http.get<UsuarioVerDto[]>(`${this.apiUrl}/usuarios`);
  }

  registrarUsuario(nuevoUsuario: UsuarioAltaDto): Observable<UsuarioAltaDto> {
    return this.http.post<UsuarioAltaDto>(`${this.apiUrl}/registro`, nuevoUsuario);
  }
}

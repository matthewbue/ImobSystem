import { Component, ViewChild } from "@angular/core";
import { Router } from "@angular/router";
import { AuthService } from "src/app/shared/services/auth.service";

@Component({
  selector: "app-system-manager",
  templateUrl: "./system-manager.component.html",
  styleUrls: ["./system-manager.component.scss"],
})
export class SystemManagerComponent {
  constructor(private authService: AuthService, private router: Router) {}

  // Variáveis para armazenar imagens e informações de cada seção
  selectedBanner1Image: File;
  selectedBanner2Image: File;
  selectedBanner3Image: File;
  selectedSobre1Image: File;
  selectedFundo1Image: File;
  selectedEmpresa1Image: File;

  // Configurações para o cortador de imagem
  @ViewChild("imageCropper") imageCropper: any;
  imageChangedEvent: any = "";
  croppedImage: any = "";

  ngOnInit(): void {
    if (!this.authService.isLoggedIn()) {
      this.router.navigate(["/pages/manager"]);
    }
    // Restante da lógica da página de gerenciamento
  }

  // Funções para manipular o upload de imagens
  uploadBanner1Image() {
    // Implemente a lógica de upload para o Banner 1
  }

  uploadBanner2Image() {
    // Implemente a lógica de upload para o Banner 2
  }

  uploadBanner3Image() {
    // Implemente a lógica de upload para o Banner 3
  }

  uploadSobre1Image() {
    // Implemente a lógica de upload para o Sobre 1
  }

  uploadFundo1Image() {
    // Implemente a lógica de upload para o Fundo 1
  }

  uploadEmpresa1Image() {
    // Implemente a lógica de upload para a Empresa 1
  }

  // Funções para manipular a seleção de arquivos
  onBanner1FileSelected(event: any) {
    this.selectedBanner1Image = event.target.files[0];
  }

  onBanner2FileSelected(event: any) {
    this.selectedBanner2Image = event.target.files[0];
  }

  onBanner3FileSelected(event: any) {
    this.selectedBanner3Image = event.target.files[0];
  }

  onSobre1FileSelected(event: any) {
    this.selectedSobre1Image = event.target.files[0];
  }

  onFundo1FileSelected(event: any) {
    this.selectedFundo1Image = event.target.files[0];
  }

  onEmpresa1FileSelected(event: any) {
    this.selectedEmpresa1Image = event.target.files[0];
  }

  // Outras funções e lógica necessárias
}

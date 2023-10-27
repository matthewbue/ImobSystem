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
  imagePreview: string;
  slides = [
    { id: 1, imagePreview: "" },
    { id: 2, imagePreview: "" },
    { id: 3, imagePreview: "" },
    // Adicione mais objetos para representar outros "cards" desejados
  ];
  aboutus = [
    { id: 1, imagePreviewAbout: "" },    
    // Adicione mais objetos para representar outros "cards" desejados
  ];
fundoPage = [
  {id: 1, imagePreviewFundo: ""},
]


  ngOnInit(): void {}

  validateImageSlide(event: any, slideId: number) {
    const file = event.target.files[0];
    if (file) {
      const image = new Image();
      image.src = URL.createObjectURL(file);

      image.onload = () => {
        const minWidth = 1500; // Largura mínima desejada em pixels
        const minHeight = 1000; // Altura mínima desejada em pixels
        const maxWidth = 2000; // Largura máxima desejada em pixels
        const maxHeight = 1080; // Altura máxima desejada em pixels

        if (
          image.width < minWidth ||
          image.height < minHeight ||
          image.width > maxWidth ||
          image.height > maxHeight
        ) {
          alert(
            `A imagem do Slide ${slideId} deve estar entre ${minWidth}x${minHeight} pixels e ${maxWidth}x${maxHeight} pixels.`
          );
          // Limpa o campo de entrada de arquivo
          event.target.value = "";
        } else {
          // Atualize o objeto do slide correspondente com a imagemPreview
          this.slides[slideId - 1].imagePreview = image.src;
        }
      };
    }
  }

  uploadImageSlide(slideId: number) {
    const slide = this.slides[slideId - 1];

    if (slide.imagePreview) {
      // Lógica de envio da imagem para o servidor, se necessário
    } else {
      // Lidar com o caso em que nenhuma imagem foi selecionada.
      console.log("Nenhuma imagem selecionada para o Slide " + slideId);
    }
  }

  validateImageAbout(event: any, aboutId: number) {
    const file = event.target.files[0];
    if (file) {
      const image = new Image();
      image.src = URL.createObjectURL(file);

      image.onload = () => {
        const minWidth = 1500; // Largura mínima desejada em pixels
        const minHeight = 1000; // Altura mínima desejada em pixels
        const maxWidth = 2000; // Largura máxima desejada em pixels
        const maxHeight = 1080; // Altura máxima desejada em pixels

        if (
          image.width < minWidth ||
          image.height < minHeight ||
          image.width > maxWidth ||
          image.height > maxHeight
        ) {
          alert(
            `A imagem do Sobre-nós deve estar entre ${minWidth}x${minHeight} pixels e ${maxWidth}x${maxHeight} pixels.`
          );
          // Limpa o campo de entrada de arquivo
          event.target.value = "";
        } else {
          // Atualize o objeto do slide correspondente com a imagemPreview
          this.aboutus[aboutId - 1].imagePreviewAbout = image.src;
        }
      };
    }
  }

  uploadImageAbout(aboutId: number) {
    const about = this.aboutus[aboutId - 1];

    if (about.imagePreviewAbout) {
      // Lógica de envio da imagem para o servidor, se necessário
    } else {
      // Lidar com o caso em que nenhuma imagem foi selecionada.
      console.log("Nenhuma imagem selecionada para o Slide " + aboutId);
    }
  }

validateImageFundo(event: any, fundoId: number){
  const file = event.target.files[0];
  if (file) {
    const image = new Image();
    image.src = URL.createObjectURL(file);

    image.onload = () => {
      const minWidth = 1500; // Largura mínima desejada em pixels
      const minHeight = 1000; // Altura mínima desejada em pixels
      const maxWidth = 2000; // Largura máxima desejada em pixels
      const maxHeight = 1080; // Altura máxima desejada em pixels

      if (
        image.width < minWidth ||
        image.height < minHeight ||
        image.width > maxWidth ||
        image.height > maxHeight
      ) {
        alert(
          `A imagem do fundo deve estar entre ${minWidth}x${minHeight} pixels e ${maxWidth}x${maxHeight} pixels.`
        );
        // Limpa o campo de entrada de arquivo
        event.target.value = "";
      } else {
        // Atualize o objeto do slide correspondente com a imagemPreview
        this.fundoPage[fundoId - 1].imagePreviewFundo = image.src;
      }
    };
  }

}

uploadImageFundo(fundoId: number) {
  const fundo = this.fundoPage[fundoId - 1];

  if (fundo.imagePreviewFundo) {
    // Lógica de envio da imagem para o servidor, se necessário
  } else {
    // Lidar com o caso em que nenhuma imagem foi selecionada.
    console.log("Nenhuma imagem selecionada para o fundo " + fundoId);
  }
}


}

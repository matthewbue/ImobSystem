import { Component, ViewChild } from '@angular/core';



@Component({
  selector: 'app-system-manager',
  templateUrl: './system-manager.component.html',
  styleUrls: ['./system-manager.component.scss']
})
export class SystemManagerComponent {
  selectedImage: File | null = null;
  selectedImageUrl: string | null = null;
  uploadedImages: { url: string }[] = [];

  // Configurações para o cortador de imagem
  @ViewChild('imageCropper') imageCropper: any;
  imageChangedEvent: any = '';
  croppedImage: any = '';

  // Tamanho máximo permitido para a imagem (em bytes)
  maxSize = 1048576; // 1 MB

  onFileSelected(event: any) {
    const file = event.target.files[0] as File;

    if (file.size > this.maxSize) {
      // A imagem excede o tamanho máximo, então permite cortá-la
      this.imageChangedEvent = event;
    } else {
      // A imagem não precisa ser cortada
      this.selectedImage = file;
      this.selectedImageUrl = URL.createObjectURL(file);
    }
  }

  uploadImage() {
    if (this.selectedImage) {
      // Simule o envio da imagem para o servidor (substitua esta parte com a lógica real)
      const uploadedImageUrl = 'URL_DA_IMAGEM_ENVIADA';

      // Adicione a imagem enviada à lista de imagens
      this.uploadedImages.push({ url: uploadedImageUrl });

      // Limpe a seleção
      this.selectedImage = null;
      this.selectedImageUrl = null;
    }
  }

  // imageCropped(event: ImageCroppedEvent) {
  //   this.croppedImage = event.base64;
  // }

  imageLoaded() {
    // Imagem carregada
  }

  loadImageFailed() {
    // Falha no carregamento da imagem
  }
}

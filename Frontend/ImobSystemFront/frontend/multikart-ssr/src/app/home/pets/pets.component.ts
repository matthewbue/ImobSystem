import { Component, OnInit, OnDestroy } from '@angular/core';
import { ProductSlider } from '../../shared/data/slider';
import { Product } from '../../shared/classes/product';
import { ProductService } from '../../shared/services/product.service';

@Component({
  selector: 'app-pets',
  templateUrl: './pets.component.html',
  styleUrls: ['./pets.component.scss']
})
export class PetsComponent implements OnInit, OnDestroy {

  public themeLogo: string = 'assets/images/icon/facilita-logo2.png'; // Change Logo
  
  public products: Product[] = [];
  
  public ProductSliderConfig: any = ProductSlider;

  constructor(public productService: ProductService) {
    this.productService.getProducts.subscribe(response => {
      this.products = response.filter(item => item.type == 'pets');
    });
  }

  public sliders = [
  {
    title: '',
    subTitle: '',
    image: 'assets/images/slider/33.jpg'
  }, 
  {
    title: '',
    subTitle: 'Empreendimentos Modernos',
    image: 'assets/images/slider/31.jpeg'
  },
  {
    title: '',
    subTitle: 'Confiança do cliente',
    image: 'assets/images/slider/32.jpeg'
  },
];

  // Logo
  public logos = [{
    image: 'assets/images/logos/9.png',
  }, {
    image: 'assets/images/logos/10.png',
  }, {
    image: 'assets/images/logos/11.png',
  }, {
    image: 'assets/images/logos/12.png',
  }, {
    image: 'assets/images/logos/13.png',
  }, {
    image: 'assets/images/logos/14.png',
  }, {
    image: 'assets/images/logos/15.png',
  }, {
    image: 'assets/images/logos/16.png',        
}]

  // Collection banner
  public collections1 = [{
    image: 'assets/images/collection/pets/7.jpg',
    title: 'Assembléias',
    text: `
    - Redação e envio do Edital de Convocação.
    - Assessoria durante a realização da assembleia, com a presença de nossa equipe.
    - Elaboração e registro da ata da assembleia, distribuída aos condôminos.
    
    Facilitamos todo o processo de realização de assembleias, assegurando que seja bem organizado, documentado e em conformidade com as melhores práticas de administração condominial.
    `
  }, 
  {
    image: 'assets/images/collection/pets/8.jpg',
    title: 'Finanças',
    text: `
    - Análise da movimentação do mês atual.
    - Balancete mensal (Sintético e Analítico).
    - Previsão orçamentária.
    - Planilhas de consumo.
    - Rateio de despesas.
    - Relatório de inadimplência.
    - Consultas de extratos online.
    - Emissão de boletos bancários.
    - Gráficos com a visão geral da situação financeira do condomínio online.
     `
  },
  {
    image: 'assets/images/collection/pets/9.jpg',
    title: 'Comprometimento',
    text: `
    - Acesso online 24 horas a todas as informações financeiras do condomínio, incluindo contas do mês atual e meses anteriores, saldo diário, boletos e mais.
- Suporte na elaboração de previsões orçamentárias, acompanhamento do orçamento e revisões de contratos.
- Envio mensal de prestação de contas até o dia 15, com documentação clara e objetiva.
- Gerente dedicado para esclarecer dúvidas, auxiliar no planejamento de metas e objetivos e disponível para visitas ao prédio, conforme necessário.
     `
  }];

  public collections2 = [{
    image: 'assets/images/collection/pets/4.jpg',
    title: 'Home'
  },
  {
    image: 'assets/images/collection/pets/5.jpg',
    title: 'cats'
  },
  {
    image: 'assets/images/collection/pets/6.jpg',
    title: 'bowls'
  }];

  // Blog
  public blogs = [{
    image: 'assets/images/blog/24.jpg',
    date: '25 January 2018',
    title: 'Lorem ipsum dolor sit consectetur adipiscing elit,',
    details: 'Lorem ipsum dolor sit consectetur adipiscing elit,Lorem ipsum dolor sit consectetur adipiscing elit',
    by: 'John Dio'
  }, {
    image: 'assets/images/blog/25.jpg',
    date: '26 January 2018',
    title: 'Lorem ipsum dolor sit consectetur adipiscing elit,',
    details: 'Lorem ipsum dolor sit consectetur adipiscing elit,Lorem ipsum dolor sit consectetur adipiscing elit',
    by: 'John Dio'
  }, {
    image: 'assets/images/blog/26.jpg',
    date: '27 January 2018',
    title: 'Lorem ipsum dolor sit consectetur adipiscing elit,',
    details: 'Lorem ipsum dolor sit consectetur adipiscing elit,Lorem ipsum dolor sit consectetur adipiscing elit',
    by: 'John Dio'
  }, {
    image: 'assets/images/blog/27.jpg',
    date: '28 January 2018',
    title: 'Lorem ipsum dolor sit consectetur adipiscing elit,',
    details: 'Lorem ipsum dolor sit consectetur adipiscing elit,Lorem ipsum dolor sit consectetur adipiscing elit',
    by: 'John Dio'
  }];

  ngOnInit(): void {
    // Change color for this layout
    document.documentElement.style.setProperty('--theme-deafult', '#2837d1');
  }

  ngOnDestroy(): void {
    // Remove Color
    document.documentElement.style.removeProperty('--theme-deafult');
  }

}

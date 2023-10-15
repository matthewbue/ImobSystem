import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { PetsComponent } from "./pets/pets.component";

const routes: Routes = [
  {
    path: "facilita",
    component: PetsComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule {}

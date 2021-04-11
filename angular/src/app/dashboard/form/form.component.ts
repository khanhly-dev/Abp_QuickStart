import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CityServiceProxy } from '@shared/service-proxies/service-proxies';
import { City } from '../view_model/cityViewModel';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  constructor(private cityService : CityServiceProxy) { }

  ngOnInit(): void {
    this.getAllCity();
  }

  public formInfo = new FormGroup(
    {
      name: new FormControl(''),
      phoneNumber: new FormControl(''),
      city: new FormControl(''),
      district: new FormControl('')
    }
  )

  cityList : City[] = [];

  getCityId : number = 1;

  getAllCity() : void 
  {
    this.cityService.getAllCity().subscribe( citys => this.cityList = citys)
  }

  onCityChange() :void 
  {
    for(let i of this.cityList)
    {
      if(this.formInfo.value.city === i.name)
      {
        this.getCityId = i.id
      }
    }
    console.log(this.getCityId)
  }
}

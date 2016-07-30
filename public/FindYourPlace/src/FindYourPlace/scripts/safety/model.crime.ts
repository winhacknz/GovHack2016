import { Inject } from '@angular/core';
import { ApiService } from '../common/api.service';

export class Crime {
    id: number;
    region: string;
    incident: number;

    constructor(@Inject(ApiService) private _apiService){
        var crimeData = this.getCrimeData();
        this.id = crimeData.id;
        this.region = crimeData.region;
        this.incident = crimeData.incident;
    }

    getCrimeData(){
        return this._apiService.get('crime');
    }
}
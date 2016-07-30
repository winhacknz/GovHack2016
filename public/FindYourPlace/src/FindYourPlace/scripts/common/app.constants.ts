import { Injectable } from '@angular/core';
 
@Injectable()
export class Configuration {
    public Server: string = "http://localhost:5000/";
    public ApiUri: string = "api/";
    public ServerWithApiUrl = this.Server + this.ApiUri;
}
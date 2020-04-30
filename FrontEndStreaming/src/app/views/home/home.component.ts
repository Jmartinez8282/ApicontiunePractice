import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private dService: DataService) { }

  ngOnInit() {

    this.dService.GetTracks().subscribe(x => console.log (x));
  }

}

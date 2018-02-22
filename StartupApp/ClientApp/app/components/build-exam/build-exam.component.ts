import { Component, OnInit } from '@angular/core';
import { BuildExamService } from "../../Services/build-exam.service";

@Component({
  selector: 'app-build-exam',
  templateUrl: './build-exam.component.html',
  styleUrls: ['./build-exam.component.css']
})
export class BuildExamComponent implements OnInit {
    questionTypes;
    constructor(private buildExamService : BuildExamService) { }
   
    ngOnInit() {
        this.buildExamService.getQuestionTypes().subscribe(questionTypes => {
        this.questionTypes = questionTypes;
        console.log("Question", this.questionTypes);
        });
        
  }

}

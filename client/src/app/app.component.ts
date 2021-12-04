import { Component } from '@angular/core';
import { of } from 'rxjs';
import { MathQuestion } from './models/math-question.model';
import { CalculatorService } from './services/calculator.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  x: number = 0;
  y: number = 0;
  mathOperator: '*' | '+' | '-' | '/' = '*';

  solution: number = 0;
  errorMessage: string = '';

  constructor(private calculatorService: CalculatorService) { }

  onSubmit(): void {
    const question: MathQuestion = { x: this.x, y: this.y, mathOperator: this.mathOperator };
    this.calculatorService.calculateMathQuestion(question).subscribe(res => {
      this.solution = res;
    }, (err) => {
      console.log(err);
      if (err.status === 400) {
        this.errorMessage = err.error.message;
      } else {
        console.log(err.status);
      }
    });
  }
}

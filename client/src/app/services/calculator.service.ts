import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {
  MathQuestion,
  MathQuestionEndCoded,
} from '../models/math-question.model';

@Injectable({
  providedIn: 'root',
})
export class CalculatorService {
  private static PLUS_SIGN_ENCODED = '%2B';
  constructor(private http: HttpClient) { }

  calculateMathQuestion(mathQuestion: MathQuestion): Observable<{ value: number; }> {
    return this.http.get<{ value: number; }>(environment.baseurl + '/math-calculator' + this.uriParams(mathQuestion), {
      // params: { ...mathQuestion },
    });
  }

  // angualr dose wierd mannuplatopn on '+' so i add manualy the params
  private uriParams(mathQuestion: MathQuestion): string {
    mathQuestion = { ...mathQuestion };
    if (mathQuestion.mathOperator === '+') mathQuestion.mathOperator = CalculatorService.PLUS_SIGN_ENCODED as '+';
    return `?mathOperator=${mathQuestion.mathOperator}&x=${mathQuestion.x}&y=${mathQuestion.y}`;
  }


}

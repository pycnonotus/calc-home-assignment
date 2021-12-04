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

  calculateMathQuestion(mathQuestion: MathQuestion): Observable<number> {
    return this.http.get<number>(environment.baseurl + '/math-calculator', {
      params: { ...mathQuestion },
    });
  }

  private mathQuestionToParams(mathQuestion: MathQuestion): HttpParams {
    let params = new HttpParams();
    params = params.set('x', mathQuestion.x);
    params = params.set('y', mathQuestion.y);
    params = params.set('mathOperator', mathQuestion.mathOperator);
    return params;
  }

  private endCode(mathQuestion: MathQuestion): MathQuestionEndCoded {
    return {
      ...mathQuestion,
      mathOperator: (mathQuestion.mathOperator === '+'
        ? CalculatorService.PLUS_SIGN_ENCODED
        : mathQuestion.mathOperator) as any, // HACK! , webpack thinks it is a string and not NotProblematicChars | '%2B'
    };
  }
}

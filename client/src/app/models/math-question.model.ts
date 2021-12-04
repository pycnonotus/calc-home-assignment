export interface MathQuestion {
  x: number;
  y: number;
  mathOperator: NotProblematicChars | '+';
}

export interface MathQuestionEndCoded extends Omit<MathQuestion, "mathOperator"> {
  mathOperator: NotProblematicChars | '%2B';
};

type NotProblematicChars = '*' | '/' | '-';

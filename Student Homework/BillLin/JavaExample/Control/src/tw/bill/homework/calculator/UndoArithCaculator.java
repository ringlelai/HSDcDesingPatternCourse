package tw.bill.homework.calculator;

public class UndoArithCaculator extends Caculator {
	private int _curr = 0;

	public int GetResult(){
		return _curr;
	}

	public void Operation(String operator, int operand){
        switch (operator)
        {
            case "+": _curr -= operand; break;
            case "-": _curr += operand; break;
            case "*": _curr /= operand; break;
            case "/": _curr *= operand; break;
        }
	}

}

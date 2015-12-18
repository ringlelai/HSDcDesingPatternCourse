package tw.bill.homework.calculator;

public class ElementaryArithCaculator extends Caculator {

	private int _curr = 0;
	private int result = 0;

	public int GetResult(){
		return _curr;
	}

	public void Operation(String operator, int operand){
        switch (operator)
        {
            case "+": _curr += operand; break;
            case "-": _curr -= operand; break;
            case "*": _curr *= operand; break;
            case "/": _curr /= operand; break;
            case "=": result = _curr; break;
        }
	}

}
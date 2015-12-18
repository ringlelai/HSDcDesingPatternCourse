package tw.bill.homework.calculator;

public class ElementaryArithCommand extends Command {

	private ElementaryArithCaculator _caculator;

	public ElementaryArithCommand(Object receiver, String Operator, int Operand){
		super(receiver, Operator, Operand);
        if (receiver.getClass().getTypeName().equals(ElementaryArithCaculator.class.getTypeName()))
            this._caculator = (ElementaryArithCaculator)receiver;
	}

	public void Execute(){
        if (this._caculator != null)
            this._caculator.Operation(Operator, Operand);
	}

}
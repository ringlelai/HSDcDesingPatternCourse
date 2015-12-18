package tw.bill.homework.calculator;

public class UndoArithCommand extends Command {
	
	private UndoArithCaculator _caculator;

	public UndoArithCommand(Object receiver, String Operator, int Operand){
		super(receiver, Operator, Operand);
        if (receiver.getClass().getTypeName().equals(ElementaryArithCaculator.class.getTypeName()))
            this._caculator = (UndoArithCaculator)receiver;
	}

	public void Execute(){
        if (this._caculator != null)
            this._caculator.Operation(Operator, Operand);
	}

}

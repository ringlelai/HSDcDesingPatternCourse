package tw.bill.homework.calculator;

public abstract class Command {

	protected int Operand;
	protected String Operator;
	private Object receiver;
	
	public abstract void Execute();

	public Command(Object receiver, String Operator, int Operand){
		this.receiver = receiver;
        this.Operator = Operator;
        this.Operand = Operand;
	}
}
package tw.bill.homework.calculator;

import java.util.ArrayList;
import java.util.List;

public class CalculationInvoker {

	private List<Command> commands = new ArrayList<Command>();

	public void addCommand(Object receiver, String operator, int operand){
        Command command = new ElementaryArithCommand(
          receiver, operator, operand);
        commands.add(command);
	}
	
	public void underCommand(Object receiver, String operator, int operand) {
		// TODO Bill remove command
		Command command = new UndoArithCommand(receiver, operator, operand);
		commands.add(command);
	}
	
	public void execute() {
		for(Command item : commands) {
			
		}
	}

}
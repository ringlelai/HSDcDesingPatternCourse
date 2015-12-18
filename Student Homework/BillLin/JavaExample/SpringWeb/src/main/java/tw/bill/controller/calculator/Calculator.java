package tw.bill.controller.calculator;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.homework.calculator.CalculationInvoker;
import tw.bill.homework.calculator.ElementaryArithCaculator;

@RestController
public class Calculator {
	private static ElementaryArithCaculator receiver;
	
	@RequestMapping(value="/addCommand", method=RequestMethod.GET)
	public int compute(
			@RequestParam(value="operand", defaultValue="1")int operand, 
			@RequestParam(value="operator", defaultValue="+")String operator) {
        
        if (receiver == null)
        {
        	receiver = new ElementaryArithCaculator();
        }
        (new CalculationInvoker()).addCommand(operator, operator, operand);
		
		return receiver.GetResult();
	}
	
	@RequestMapping(value="/clear", method=RequestMethod.GET)
	public int clear() {
        receiver = new ElementaryArithCaculator();
        return receiver.GetResult();
	}
}

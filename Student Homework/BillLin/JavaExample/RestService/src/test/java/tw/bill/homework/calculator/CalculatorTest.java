package tw.bill.homework.calculator;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import tw.bill.controller.calculator.Calculator;

public class CalculatorTest {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testCompute() {
		int operand = 1;
		String operator = "+";
		
		Calculator target = new Calculator();
		int actual = target.compute(operand, operator);
		
		int expected = 1;
		assertEquals(expected, actual);
		
		operand = 0;
		operator = "=";
		actual = target.compute(operand, operator);
		
		expected = 2;
		assertEquals(expected, actual);
	}

	@Test public void testClear() {
		Calculator target = new Calculator();
		int actual = target.clear();
		
		int expected = 0;
		assertEquals(expected, actual);
	}

}

package com.hsdc.pattern.uccontroller.singleton;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SingletonClassTest {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testGetSingletonObject() {
		// SingletonClass obj = new SingletonClass();
		// Compilation error not allowed
		SingletonClass obj = SingletonClass.getSingletonObject();
		// Your Business Logic
		System.out.println("Singleton object obtained");
	}

}

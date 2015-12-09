package com.hsdc.pattern.uccontroller.singleton;

/**
 * http://www.wideskills.com/java-tutorial/java-singleton-design-pattern
 * @author SamChou
 *
 */
public class SingletonClass {
	private static SingletonClass singletonObject;
	/** A private Constructor prevents any other class from instantiating. */
	private SingletonClass() {
		//	 Optional Code
	}
	public static synchronized SingletonClass getSingletonObject() {
		if (singletonObject == null) {
			singletonObject = new SingletonClass();
		}
		return singletonObject;
	}
	public Object clone() throws CloneNotSupportedException {
		throw new CloneNotSupportedException();
	}
}

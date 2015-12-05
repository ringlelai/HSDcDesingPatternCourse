package tw.bill.creation.factorymethod;

import java.util.List;

// 可延伸成template method
public abstract class Telegram<I, O> {
	public abstract List<O> fetchAll();
	public abstract void send(I obj);
}

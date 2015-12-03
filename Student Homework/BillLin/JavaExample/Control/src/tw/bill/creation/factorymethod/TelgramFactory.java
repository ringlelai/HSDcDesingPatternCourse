package tw.bill.creation.factorymethod;

import java.util.List;

public abstract class TelgramFactory<I, O> {

	protected abstract Telegram<I, O> CreateTelegram();
	
	public List<O> listAll(I obj) {
		Telegram<I, O> telegram = CreateTelegram();
		telegram.send(obj);
		List<O> results = telegram.fetchAll();
		return results;
	}
}

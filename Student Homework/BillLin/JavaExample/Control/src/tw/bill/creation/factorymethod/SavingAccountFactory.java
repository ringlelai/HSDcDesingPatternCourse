package tw.bill.creation.factorymethod;

import tw.bill.dto.SavingAccount;

public class SavingAccountFactory extends TelgramFactory<SavingAccount, SavingAccount> {

	@Override
	protected Telegram<SavingAccount, SavingAccount> CreateTelegram() {
		return new SavingAccountTelgram();
	}
	

}

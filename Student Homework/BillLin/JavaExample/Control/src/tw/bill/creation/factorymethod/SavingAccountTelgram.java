package tw.bill.creation.factorymethod;

import java.util.ArrayList;
import java.util.List;

import tw.bill.dto.SavingAccount;

public class SavingAccountTelgram extends Telegram<SavingAccount, SavingAccount> {

	@Override
	public List<SavingAccount> fetchAll() {
		List<SavingAccount> results = new ArrayList<SavingAccount>();
		
		SavingAccount account1 = new SavingAccount();
		account1.setAccountNo("0010020031234");
		account1.setCurrencyType("01");
		account1.setAmount(10000);
		results.add(account1);
		
		SavingAccount account2 = new SavingAccount();
		account2.setAccountNo("0020030049999");
		account2.setCurrencyType("02");
		account2.setAmount(2000000000);
		results.add(account2);
		
		return results;
	}

	@Override
	public void send(SavingAccount obj) {
		// TODO Auto-generated method stub
		
	}

}

package tw.bill.creation.factorymethod;

import java.util.ArrayList;
import java.util.List;

import tw.bill.dto.FundAccount;

public class FundAccountTelgram extends Telegram<FundAccount, FundAccount> {

	@Override
	public List<FundAccount> fetchAll() {
		List<FundAccount> results = new ArrayList<FundAccount>();
		
		FundAccount account1 = new FundAccount();
		account1.setAccountNo("991010020031234");
		account1.setCurrencyType("01");
		account1.setAmount(10000);
		results.add(account1);
		
		FundAccount account2 = new FundAccount();
		account2.setAccountNo("9920030049999");
		account2.setCurrencyType("02");
		account2.setAmount(2000000000);
		results.add(account2);
		
		return results;
	}

	@Override
	public void send(FundAccount obj) {
		// TODO Auto-generated method stub
		
	}

}

package tw.bill.homework.singleton;

import java.util.List;

import tw.bill.creation.factorymethod.FundAccountFactory;
import tw.bill.creation.factorymethod.SavingAccountFactory;
import tw.bill.dto.FundAccount;
import tw.bill.dto.SavingAccount;

public class AccountService {
	private static List<SavingAccount> savingAccounts;
	private static List<FundAccount> fundAccounts;
	
	private AccountService() {
		
	}
	
	public static List<SavingAccount> getSavingAccounts(String id) {
		if (savingAccounts == null) {
			synchronized (savingAccounts) {
				if (savingAccounts == null) {
					SavingAccountFactory factory = new SavingAccountFactory();
					SavingAccount account = new SavingAccount();
					account.setId(id);
					savingAccounts = factory.listAll(account);
				}
			}

		}
		return savingAccounts;
	}
	
	public static List<FundAccount> getFundAccounts(String id) {
		if(fundAccounts == null) {
			synchronized (fundAccounts) {
				if(fundAccounts == null) {
					FundAccountFactory factory = new FundAccountFactory();
					FundAccount account = new FundAccount();
					account.setId(id);
					fundAccounts = factory.listAll(account);
				}
			}
		}
		return fundAccounts;
	}
}

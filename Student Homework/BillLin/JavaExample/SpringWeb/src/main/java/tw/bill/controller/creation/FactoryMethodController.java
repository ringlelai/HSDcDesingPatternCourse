package tw.bill.controller.creation;

import java.util.List;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.creation.factorymethod.FundAccountFactory;
import tw.bill.creation.factorymethod.SavingAccountFactory;
import tw.bill.creation.factorymethod.TelgramFactory;
import tw.bill.dto.FundAccount;
import tw.bill.dto.SavingAccount;

@RestController
public class FactoryMethodController {
	
	@RequestMapping("/Creation/FactoryMethod/SavingAccounts")
	public List<SavingAccount> fetchSavingAccounts() {
		TelgramFactory<SavingAccount, SavingAccount> factory = new SavingAccountFactory();
		List<SavingAccount> results = factory.listAll(new SavingAccount());
		return results;
	}
	
	@RequestMapping("/Creation/FactoryMethod/FundAccounts")
	public List<FundAccount> fetchFundAccounts() {
		TelgramFactory<FundAccount, FundAccount> factory = new FundAccountFactory();
		List<FundAccount> results = factory.listAll(new FundAccount());
		return results;
	}
}

package tw.bill.creation.factorymethod;

import tw.bill.dto.FundAccount;

public class FundAccountFactory extends TelgramFactory<FundAccount, FundAccount> {

	@Override
	protected Telegram<FundAccount, FundAccount> CreateTelegram() {
		return new FundAccountTelgram();
	}

}

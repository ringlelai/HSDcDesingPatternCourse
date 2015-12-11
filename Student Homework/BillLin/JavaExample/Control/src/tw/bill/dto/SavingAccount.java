package tw.bill.dto;

public class SavingAccount {
	private String id;
	private String accountNo;
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	private String accountName;
	private String currencyType;
	private int amount;
	
	public String getAccountNo() {
		return accountNo;
	}
	public void setAccountNo(String accountNo) {
		this.accountNo = accountNo;
	}
	public String getAccountName() {
		return accountName;
	}
	public void setAccountName(String accountName) {
		this.accountName = accountName;
	}
	public String getCurrencyType() {
		return currencyType;
	}
	public void setCurrencyType(String currencyType) {
		this.currencyType = currencyType;
	}
	public int getAmount() {
		return amount;
	}
	public void setAmount(int amount) {
		this.amount = amount;
	}
	
}

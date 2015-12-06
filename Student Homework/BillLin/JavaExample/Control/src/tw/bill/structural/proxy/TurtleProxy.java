package tw.bill.structural.proxy;

public class TurtleProxy implements SellService {

	@Override
	public String fetchLicence(String type) {
		if(type.equals("陸龜")) {
			SellService info = new TurtleInfomer();
			return info.fetchLicence(type);
		}
		else {
			return "BBBB";
		}
	}

}

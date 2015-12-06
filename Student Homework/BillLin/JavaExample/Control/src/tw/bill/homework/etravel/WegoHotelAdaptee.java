package tw.bill.homework.etravel;

import tw.bill.dto.Hotel;

public class WegoHotelAdaptee implements IHotelAdapter {

	@Override
	public Hotel getHotelInfo() {
		// TODO wait to implement the connection to Wego hotel service
		return new Hotel();
	}
	
}

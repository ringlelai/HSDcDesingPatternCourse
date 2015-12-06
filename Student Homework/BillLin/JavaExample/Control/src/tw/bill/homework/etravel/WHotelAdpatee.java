package tw.bill.homework.etravel;

import tw.bill.dto.Hotel;

public class WHotelAdpatee implements IHotelAdapter{

	@Override
	public Hotel getHotelInfo() {
		// TODO: connection to W Hotel for geting the detail info
		return new Hotel();
	}
	
}

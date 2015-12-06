package tw.bill.homework.tripadvisor;

import tw.bill.dto.Hotel;

public class ExpediaPriceSearcher implements IHotelPriceSearcher {

	@Override
	public void updateHotelPrice(Hotel hotel) {
		int price = 10000;
		hotel.setMinPrice(price);
	}

}

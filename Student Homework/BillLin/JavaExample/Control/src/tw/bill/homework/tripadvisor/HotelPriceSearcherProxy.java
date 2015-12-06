package tw.bill.homework.tripadvisor;

import tw.bill.dto.Hotel;

public class HotelPriceSearcherProxy implements IHotelPriceSearcher {
	
	@Override
	public void updateHotelPrice(Hotel hotel) {
		if(isOutofDate(hotel) || isPriceEmpty(hotel)) {
			IHotelPriceSearcher expediaService = new ExpediaPriceSearcher();
			expediaService.updateHotelPrice(hotel);
		}
	}

	private boolean isPriceEmpty(Hotel hotel) {
		// TODO Wiat to implement the the method of checking price
		return true;
	}

	private boolean isOutofDate(Hotel hotel) {
		// TODO Wait to implement the method of the data which whether is out of date
		return true;
	}
}

package tw.bill.homework.tripadvisor;

import java.util.List;

import tw.bill.dao.LocalDb;
import tw.bill.dto.Hotel;

class TripAdvisorService {

	public List<Hotel> fetchHotel(String keyword) {
		List<Hotel> hotels = LocalDb.fetchHotels(keyword);
		IHotelPriceSearcher priceService = new HotelPriceSearcherProxy();

		for (Hotel item : hotels) {
			priceService.updateHotelPrice(item);
		}

		return hotels;
	}
}

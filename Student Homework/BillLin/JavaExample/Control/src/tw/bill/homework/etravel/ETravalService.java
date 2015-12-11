package tw.bill.homework.etravel;

import java.util.ArrayList;
import java.util.List;

import tw.bill.dao.LocalDb;
import tw.bill.dto.Hotel;

public class ETravalService {

	public List<Hotel> fetchHotels(String keyword) {
		List<String> hotelNames = LocalDb.fetchHotelNames(keyword);
		List<Hotel> results = new ArrayList<>();
		
		for(String item : hotelNames) {
			IHotelAdapter adapter;
			switch (item) {
			case "Wego Hotel":
				adapter = new WegoHotelAdaptee();
				break;
			case "W Hotel":
				adapter = new WHotelAdpatee();
				break;
			default:
				throw new RuntimeException("Not implement this Hotel type");
			}
			
			setupHotelInfo(results, adapter);
		}
		
		return results;
	}

	private void setupHotelInfo(List<Hotel> results, IHotelAdapter adapter) {
		results.add(adapter.getHotelInfo());
	}

}

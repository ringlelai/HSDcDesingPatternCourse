package tw.bill.dao;

import java.util.ArrayList;
import java.util.List;

import tw.bill.dto.Hotel;

public class LocalDb {

	public static List<Hotel> fetchHotels(String keyword) {
		List<Hotel> results = new ArrayList<>();
		
		Hotel hotel = new Hotel();
		hotel.setName("一級棒");
		hotel.setStar(1);
		hotel.setCountry("Taiwan");
		hotel.setAddress("xxx路xx號");
		hotel.setMinPrice(1000);
		results.add(hotel);
		
		return results;
	}
	
	public static List<String> fetchHotelNames(String keyword) {
		List<String> results = new ArrayList<>();
		results.add("W Hotel");
		results.add("Wego Hotel");
		return results;
	}

}

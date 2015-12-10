package tw.bill.homework.hotel;

import java.util.List;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.dto.Hotel;

@RestController
public class TripAdvisorHotels {
	
	@RequestMapping(value="/TripAdvisor/Hotes", method=RequestMethod.GET) 
	public List<Hotel> fetchHotel(@RequestParam(required=true, value="") String keyword) {
		
		
		return null;
	}
}

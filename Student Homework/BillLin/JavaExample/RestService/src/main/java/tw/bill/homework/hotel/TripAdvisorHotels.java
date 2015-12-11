package tw.bill.homework.hotel;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.dto.Hotel;
import tw.bill.homework.tripadvisor.TripAdvisorService;

@RestController
public class TripAdvisorHotels {
	
	@RequestMapping(value="/TripAdvisor/Hotes", method=RequestMethod.GET) 
	public List<Hotel> fetchHotel(@RequestParam(required=true, value="") String keyword) {
		List<Hotel> results;
		try {
			TripAdvisorService service = new TripAdvisorService();
			results = service.fetchHotel(keyword);
		} catch (Exception e) {
			// TODO: Need to implement the message wrapper
			results = new ArrayList<Hotel>();
		}
		return results;
	}
}

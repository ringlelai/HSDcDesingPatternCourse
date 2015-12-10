package tw.bill.homework.hotel;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.dto.Hotel;
import tw.bill.homework.etravel.ETravalService;

@RestController
public class ETravelHotels {

	@RequestMapping(value="/ETravel/Hotels", method=RequestMethod.GET)
	public List<Hotel> fetchHotels(@RequestParam(required=true, value="") String keyword) {
		List<Hotel> results;
		
		try {
			ETravalService service = new ETravalService();
			results = service.fetchHotels(keyword);
		} catch (Exception e) {
			// TODO: Need to implement the message wrapper
			results = new ArrayList<Hotel>();
		}
		
		return results;
	}
}

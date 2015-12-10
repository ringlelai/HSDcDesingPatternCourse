package tw.bill.homework.hotel;

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
		ETravalService service = new ETravalService();
		List<Hotel> results = null;
		
		try {
			results = service.fetchHotels(keyword);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return results;
	}
}

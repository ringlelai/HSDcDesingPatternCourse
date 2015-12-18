package tw.bill.controller.structural;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import tw.bill.structural.proxy.SellService;
import tw.bill.structural.proxy.TurtleProxy;

@RestController
public class Proxy {
	@RequestMapping(value="/Structural/Proxy", method=RequestMethod.GET)
	public String fetchLicence(@RequestParam(required=true, value="陸龜") String turtleType) {
		SellService service = new TurtleProxy();
		String result = service.fetchLicence(turtleType);
		return result;
	}
}

package com.hsdc.pattern.boundary.expeida;

import static com.hsdc.pattern.uccontroller.expeida.RetrieveVendorHotelInfoCtrler.VendorUrl.*;

import java.net.URL;
import java.util.HashMap;
import java.util.Map;

import com.hsdc.pattern.dto.expeida.HotelDto;
import com.hsdc.pattern.uccontroller.expeida.RetrieveVendorHotelInfoCtrler.VendorUrl;

public class RetrieveVendorHotelInfo implements IRetrieveVendorHotelInfo {
	
	private static Map<VendorUrl, HotelDto> hotelMsg = new HashMap<VendorUrl, HotelDto>();
	
	static{
		hotelMsg.put(SHERATON, new HotelDto("SHERATON", "*****", "5678", "10"));
		hotelMsg.put(CRYSTAL, new HotelDto("CRYSTAL", "*****", "1234", "1"));
		hotelMsg.put(WEGO, new HotelDto("WEGO", "*****", "2345", "1"));
	}
	
	private URL url = null;
	
	public RetrieveVendorHotelInfo(URL url) {
		this.url = url;
	}

	public HotelDto retrieveVendorHotelInfo(){

		return hotelMsg.get(VendorUrl.findEnum(url.toString()));
	}


}

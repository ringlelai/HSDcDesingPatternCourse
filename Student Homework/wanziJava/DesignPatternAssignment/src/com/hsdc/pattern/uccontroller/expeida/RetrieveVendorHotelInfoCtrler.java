package com.hsdc.pattern.uccontroller.expeida;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

import com.hsdc.pattern.boundary.expeida.IRetrieveVendorHotelInfo;
import com.hsdc.pattern.boundary.expeida.RetrieveVendorHotelInfoProxy;
import com.hsdc.pattern.dto.expeida.HotelDto;

public class RetrieveVendorHotelInfoCtrler {
	public List<HotelDto> collectVendorHotelInfo() throws MalformedURLException{
		List<HotelDto> result = new ArrayList<HotelDto>();
		IRetrieveVendorHotelInfo retrieveVendorHotelInfo = null;
		for(VendorUrl each : VendorUrl.values()){
			retrieveVendorHotelInfo = new RetrieveVendorHotelInfoProxy(new URL(each.getRestUrl()));
			result.add(retrieveVendorHotelInfo.retrieveVendorHotelInfo());
		}
		
		return result;
	}

	public enum VendorUrl{
		SHERATON("http://www.sheraton-hsinchu.com/"),
		CRYSTAL("http://www.crystalmotel.com.tw/about.html"),
		WEGO("http://www.wego.com");
		
		private String restUrl;
		
		private VendorUrl(String restUrl) {
			this.restUrl = restUrl;
		}

		public String getRestUrl() {
			return restUrl;
		}
		
		public static VendorUrl findEnum(String url){
			for(VendorUrl each: VendorUrl.values())
				if(each.getRestUrl().equals(url))
					return each;
			
			return null;
		}		
	}
}

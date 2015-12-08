package com.hsdc.pattern.boundary.eztravel;

import com.hsdc.pattern.dto.eztravel.HotelDto;
import com.hsdc.pattern.vendorapi.eztravel.WeGoHotelDto;
import com.hsdc.pattern.vendorapi.eztravel.WeGoHotelInfoProvider;

public class CollectWeGoVendorHotelInfoAdaptor implements ICollectVendorHotelInfo {
	
	private WeGoHotelInfoProvider weGoHotelInfoProvider = new WeGoHotelInfoProvider();
	
	@Override
	public HotelDto collectVendorHotelInfo() {
		 WeGoHotelDto dto = weGoHotelInfoProvider.provideWeGoHotelInfo();
		 
		 return new HotelDto(dto.getName(), dto.getGrade(), dto.getMinPrice(), dto.getAvailableRooms());
	}

}

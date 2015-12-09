package com.hsdc.pattern.boundary.eztravel;

import com.hsdc.pattern.dto.eztravel.HotelDto;
import com.hsdc.pattern.vendorapi.eztravel.SheratonHotelDto;
import com.hsdc.pattern.vendorapi.eztravel.SheratonHotelInfoProvider;

public class CollectSheratonVendorHotelInfoAdaptor implements ICollectVendorHotelInfo {
	
	private SheratonHotelInfoProvider sheratonHotelInfoProvider = new SheratonHotelInfoProvider();
	
	@Override
	public HotelDto collectVendorHotelInfo() {
		 SheratonHotelDto dto = sheratonHotelInfoProvider.provideSheratonHotelInfo();
		 
		 return new HotelDto(dto.getName(), dto.getGrade(), dto.getMinPrice(), dto.getAvailableRooms());
	}

}

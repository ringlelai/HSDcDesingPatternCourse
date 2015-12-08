package com.hsdc.pattern.boundary.eztravel;

import com.hsdc.pattern.dto.eztravel.HotelDto;
import com.hsdc.pattern.vendorapi.eztravel.CrystalHotelDto;
import com.hsdc.pattern.vendorapi.eztravel.CrystalHotelInfoProvider;

public class CollectCrystalVendorHotelInfoAdaptor implements ICollectVendorHotelInfo {
	
	private CrystalHotelInfoProvider crystalHotelInfoProvider = new CrystalHotelInfoProvider();
	
	@Override
	public HotelDto collectVendorHotelInfo() {
		 CrystalHotelDto dto = crystalHotelInfoProvider.provideCrystalHotelInfo();
		 
		 return new HotelDto(dto.getName(), dto.getGrade(), dto.getMinPrice(), dto.getAvailableRooms());
	}

}

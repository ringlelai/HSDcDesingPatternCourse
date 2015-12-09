package com.hsdc.pattern.boundary.eztravel;

import com.hsdc.pattern.dto.eztravel.HotelDto;

public class CollectCrystalVendorHotelInfo implements ICollectVendorHotelInfo {

	@Override
	public HotelDto collectVendorHotelInfo() {
		
		return getAdatpor().collectVendorHotelInfo();
	}

	private ICollectVendorHotelInfo getAdatpor(){
		return new CollectCrystalVendorHotelInfoAdaptor();
	}
}

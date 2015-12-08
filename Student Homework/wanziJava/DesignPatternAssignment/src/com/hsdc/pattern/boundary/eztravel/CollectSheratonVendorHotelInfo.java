package com.hsdc.pattern.boundary.eztravel;

import com.hsdc.pattern.dto.eztravel.HotelDto;

public class CollectSheratonVendorHotelInfo implements ICollectVendorHotelInfo {

	@Override
	public HotelDto collectVendorHotelInfo() {
		
		return getAdatpor().collectVendorHotelInfo();
	}

	private ICollectVendorHotelInfo getAdatpor(){
		return new CollectSheratonVendorHotelInfoAdaptor();
	}
}

package com.hsdc.pattern.uccontroller.eztravel;

import java.util.ArrayList;
import java.util.List;

import com.hsdc.pattern.boundary.eztravel.CollectCrystalVendorHotelInfoAdaptor;
import com.hsdc.pattern.boundary.eztravel.CollectSheratonVendorHotelInfoAdaptor;
import com.hsdc.pattern.boundary.eztravel.CollectWeGoVendorHotelInfoAdaptor;
import com.hsdc.pattern.boundary.eztravel.ICollectVendorHotelInfo;
import com.hsdc.pattern.dto.eztravel.HotelDto;

public class CollectVendorHotelInfoCtrler {
	private static List<ICollectVendorHotelInfo> colVendorHotelBoundaries = new ArrayList<ICollectVendorHotelInfo>();
	static{
		colVendorHotelBoundaries.add(new CollectCrystalVendorHotelInfoAdaptor());
		colVendorHotelBoundaries.add(new CollectSheratonVendorHotelInfoAdaptor());
		colVendorHotelBoundaries.add(new CollectWeGoVendorHotelInfoAdaptor());
	}
	
	public List<HotelDto> collectVendorHotelInfo(){
		List<HotelDto> rlt = new ArrayList<HotelDto>();
		for(ICollectVendorHotelInfo each : colVendorHotelBoundaries){
			rlt.add(each.collectVendorHotelInfo());
		}
		return rlt;
	}
}

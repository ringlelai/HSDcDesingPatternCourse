package com.hsdc.pattern.uccontroller.eztravel;

import java.util.ArrayList;
import java.util.List;

import com.hsdc.pattern.boundary.eztravel.CollectCrystalVendorHotelInfo;
import com.hsdc.pattern.boundary.eztravel.CollectSheratonVendorHotelInfo;
import com.hsdc.pattern.boundary.eztravel.CollectWeGoVendorHotelInfo;
import com.hsdc.pattern.boundary.eztravel.ICollectVendorHotelInfo;
import com.hsdc.pattern.dto.eztravel.HotelDto;

public class CollectVendorHotelInfoCtrler {
	private static List<ICollectVendorHotelInfo> colVendorHotelBoundaries = new ArrayList<ICollectVendorHotelInfo>();
	static{
		colVendorHotelBoundaries.add(new CollectCrystalVendorHotelInfo());
		colVendorHotelBoundaries.add(new CollectSheratonVendorHotelInfo());
		colVendorHotelBoundaries.add(new CollectWeGoVendorHotelInfo());
	}
	
	public List<HotelDto> collectVendorHotelInfo(){
		List<HotelDto> rlt = new ArrayList<HotelDto>();
		for(ICollectVendorHotelInfo each : colVendorHotelBoundaries){
			rlt.add(each.collectVendorHotelInfo());
		}
		return rlt;
	}
}

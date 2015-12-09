package com.hsdc.pattern.uccontroller.eztravel;

import static org.junit.Assert.*;

import java.util.List;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.hsdc.pattern.dto.eztravel.HotelDto;

public class CollectVendorHotelInfoCtrlerTest {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testCollectVendorHotelInfo() {
		CollectVendorHotelInfoCtrler collectVendorHotelInfoCtrler = new CollectVendorHotelInfoCtrler();
		List<HotelDto> result = collectVendorHotelInfoCtrler.collectVendorHotelInfo();
		
		for(HotelDto each : result){
			System.out.println(each);
		}
	}

}

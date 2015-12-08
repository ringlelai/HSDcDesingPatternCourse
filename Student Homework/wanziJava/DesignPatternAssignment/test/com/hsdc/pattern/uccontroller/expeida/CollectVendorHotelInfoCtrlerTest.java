package com.hsdc.pattern.uccontroller.expeida;

import static org.junit.Assert.*;

import java.net.MalformedURLException;
import java.util.List;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.hsdc.pattern.dto.expeida.HotelDto;

public class CollectVendorHotelInfoCtrlerTest {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testCollectVendorHotelInfo() throws MalformedURLException {
		RetrieveVendorHotelInfoCtrler collectVendorHotelInfoCtrler = new RetrieveVendorHotelInfoCtrler();
		List<HotelDto> hotelInfos = collectVendorHotelInfoCtrler.collectVendorHotelInfo();
		for(HotelDto each : hotelInfos ){
			System.out.println(each);
		}
	}

}

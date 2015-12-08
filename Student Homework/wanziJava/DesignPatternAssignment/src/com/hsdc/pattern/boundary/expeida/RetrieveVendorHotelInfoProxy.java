package com.hsdc.pattern.boundary.expeida;

import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URL;

import com.hsdc.pattern.dto.expeida.HotelDto;

public class RetrieveVendorHotelInfoProxy implements IRetrieveVendorHotelInfo {
	
	private RetrieveVendorHotelInfo retrieveVendorHotelInfo = null;
	private URL url = null;
	
	public RetrieveVendorHotelInfoProxy(URL url) {
		super();
		this.url = url;
	}

	@Override
	public HotelDto retrieveVendorHotelInfo() {
		try {
			HttpURLConnection conn = (HttpURLConnection)url.openConnection();
			
			if("OK".endsWith(conn.getResponseMessage())==false)
				return null;
			
			retrieveVendorHotelInfo = new RetrieveVendorHotelInfo(url);
			return retrieveVendorHotelInfo.retrieveVendorHotelInfo();
		} catch (IOException e) {
			throw new RuntimeException(e);
		}
	}

}

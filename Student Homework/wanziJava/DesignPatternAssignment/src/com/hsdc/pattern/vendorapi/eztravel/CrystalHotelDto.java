package com.hsdc.pattern.vendorapi.eztravel;

public class CrystalHotelDto {
	
	private String name;
	private String grade;
	private String minPrice;
	private String availableRooms;

	public CrystalHotelDto(String name, String grade, String minPrice,String availableRooms) {
		this.name = name;
		this.grade = grade;
		this.minPrice = minPrice;
		this.availableRooms = availableRooms;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getGrade() {
		return grade;
	}

	public void setGrade(String grade) {
		this.grade = grade;
	}

	public String getMinPrice() {
		return minPrice;
	}

	public void setMinPrice(String minPrice) {
		this.minPrice = minPrice;
	}

	public String getAvailableRooms() {
		return availableRooms;
	}

	public void setAvailableRooms(String availableRooms) {
		this.availableRooms = availableRooms;
	}

	public String toString() {
		return "HotelDto [name=" + name + ", grade=" + grade + ", minPrice="
				+ minPrice + ", availableRooms=" + availableRooms + "]";
	}
}

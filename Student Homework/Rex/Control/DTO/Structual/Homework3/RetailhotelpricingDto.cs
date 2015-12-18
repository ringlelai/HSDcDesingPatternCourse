namespace hsdc.dpt.Control.DTO.Structual.Homework3
{
    public class RetailhotelpricingDto
    {
        public bool isShowPricePopup { get; set; }
        public bool isShowPriceDisclaimer { get; set; }
        public float priceWithoutDrr { get; set; }
        public float price { get; set; }
        public int taxesAndFee { get; set; }
        public string priceWithoutDrrFormatted { get; set; }
        public float percentageSavings { get; set; }
        public string priceFormatted { get; set; }
        public string currencySymbol { get; set; }
        public bool showCurrencyAsSuffix { get; set; }
        public string ratePlanId { get; set; }
        public bool isMultiRatePlan { get; set; }
        public bool isBurnApplied { get; set; }
        public string packageSavingsFormatted { get; set; }
        public string referencePriceFormatted { get; set; }
        public bool isPackageSavingsSignificant { get; set; }
        public string pricePerNightFormatted { get; set; }
        public string referencePricePerNightFormatted { get; set; }
        public bool isDynamicPrice { get; set; }
        public bool isDrrDiscount { get; set; }
        public bool isDisplayDrrTooltip { get; set; }
        public string drrMessage { get; set; }
        public bool isMemberDiscount { get; set; }
        public int hotmipExpiration { get; set; }
        public int hotmipSecondsLeft { get; set; }
        public int hotmipPercentage { get; set; }
        public bool isHotmipThirdParty { get; set; }
        public string unavailableDescriptionRoom { get; set; }
        public string pricingStartDate { get; set; }
        public string pricingEndDate { get; set; }
        public int pricingNumberOfNightStay { get; set; }
        public int numOfRetailHotelRooms { get; set; }
        public int availabilityRoomCount { get; set; }
        public string continueButtonDesc { get; set; }
        public int pricingWindowRange { get; set; }
        public string pricingInfositeQueryString { get; set; }
        public int priceBucket { get; set; }
        public bool isETP { get; set; }
        public bool isPriceModified { get; set; }
        public float surveyPriceHigh { get; set; }
        public bool isChannelTypeMobile { get; set; }
        public bool isPointOfSupplyCurrency { get; set; }
        public string hotelId { get; set; }
        public string hotelType { get; set; }
        public string automationId { get; set; }
        public bool esrHotel { get; set; }
        public int drrTagID { get; set; }
        public int drrDescriptionID { get; set; }
        public int drrSecondsLeft { get; set; }
        public string drrExpirationDate { get; set; }
        public bool isSrcTypeRestricted { get; set; }

        //public Restrictiontype restrictionType { get; set; }
        public string[] errorMessages { get; set; }

        public string errorCode { get; set; }
        public bool showClickMarkerForPrice { get; set; }
    }
}
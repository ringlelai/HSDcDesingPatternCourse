namespace hsdc.dpt.Control.DTO.Structual.Homework3.Expedia
{
    public class ExpediaSearchResultDto
    {
        public RetailhotelinfoDto retailHotelInfoModel { get; set; }
        public RetailhotelpricingDto retailHotelPricingModel { get; set; }

        public string hotelId { get; set; }
        public string cityName { get; set; }

        public string normalizedHotelName { get; set; }
        public bool isFreeCancel { get; set; }
        public bool isPayLater { get; set; }
        public string infositeUrl { get; set; }
        public bool isSponsoredListing { get; set; }
        public bool isSponsoredLinkOffListing { get; set; }
        public string sponsoredListingClickTrackingRedirectUrl { get; set; }
        public string sponsoredListingImpressionTrackingUrl { get; set; }
        public string sponsoredListingExternalUrl { get; set; }
        public bool isDealOfTheDayListing { get; set; }
        public bool isCouponEligible { get; set; }
        public bool isSelectedListing { get; set; }
        public bool isGpgHotel { get; set; }
        public bool isLastStayedAt { get; set; }
        public bool isVacationRental { get; set; }
        public long freeCancelDate { get; set; }
        public int supplierScore { get; set; }
        public bool isTopHotel { get; set; }
        public bool isTravelAdCopyAvailable { get; set; }
        public int listingPosition { get; set; }
        public int listingTotal { get; set; }
        public string decoration { get; set; }
    }
}
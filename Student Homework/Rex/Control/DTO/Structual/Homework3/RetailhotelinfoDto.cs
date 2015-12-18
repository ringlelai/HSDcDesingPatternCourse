namespace hsdc.dpt.Control.DTO.Structual.Homework3
{
    public class RetailhotelinfoDto
    {
        public string searchDestination { get; set; }
        public string searchType { get; set; }
        public bool datelessSearch { get; set; }
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public string localizedHotelName { get; set; }
        public string normalizedHotelName { get; set; }
        public string cityName { get; set; }
        public string twoLetterCountry { get; set; }
        public string threeLetterCountry { get; set; }
        public string provinceName { get; set; }
        public string neighborhood { get; set; }
        public string hotelDescription { get; set; }
        public string structureType { get; set; }
        public string cityAndNeighborhood { get; set; }
        public string shortneighborhood { get; set; }
        public string thumbnailURL { get; set; }
        public string largeThumbnailURL { get; set; }
        public string hotelStarRating { get; set; }
        public string hotelStarRatingCss { get; set; }
        public bool isOfficialStarRating { get; set; }
        public bool showDistanceInfo { get; set; }
        public float distanceInMiles { get; set; }
        public float distanceInKilometers { get; set; }
        public bool showMile { get; set; }
        public string distanceFormat { get; set; }
        public string localizedDistanceInMiles { get; set; }
        public string localizedDistanceInKilometers { get; set; }
        public bool hasLatitudeLongitudeInfo { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string automationId { get; set; }
        public string hotelType { get; set; }
        public string woodpeckerHotelType { get; set; }
        public bool aDudleyHotel { get; set; }
        public bool esrHotel { get; set; }
        public bool opaqueHotel { get; set; }
        public bool venereHotel { get; set; }
        public bool gdsHotel { get; set; }
        public bool daHotel { get; set; }
        public bool wotifHotel { get; set; }
        public bool jumboHotel { get; set; }
        public string reviewOverall { get; set; }
        public string reviewOverallCss { get; set; }
        public int reviewTotal { get; set; }
        public bool showRatingAndReviews { get; set; }
        public bool showReviews { get; set; }
        public float reviewPercentage { get; set; }
        public float cleanlinessRating { get; set; }
        public float serviceAndStaffRating { get; set; }
        public float roomComfortRating { get; set; }
        public float hotelConditionRating { get; set; }
        public bool showPhoneNumber { get; set; }
        public bool showPhoneTooltip { get; set; }
        public string phoneTooltipURL { get; set; }
        public string telephoneNumber { get; set; }
        public int numberOfRoomsLeftForUrgencyMsg { get; set; }
        public bool isNumOfRoomsLeftForLeadPrice { get; set; }
        public bool isVipAccess { get; set; }
        public bool isElitePlus { get; set; }
        public bool isNewHotel { get; set; }
        public bool isInsidersSelect { get; set; }
        public string sponsoredListingDescription { get; set; }
        public string sponsoredListingHeadline { get; set; }
        public object[] hotelExtraTexts { get; set; }

        //public Familyfriendlyamenity[] familyFriendlyAmenities { get; set; }
        public bool familyFriendly { get; set; }

        public string superlativeMessage { get; set; }
    }
}
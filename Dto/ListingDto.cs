using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RvEzy.Api.Dto
{
    public class ListingDto
    {
        public int id { get; set; }
        public string listing_url { get; set; }
        public long scrape_id { get; set; }
        public DateTime? last_scraped { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string space { get; set; }
        public string description { get; set; }
        public string experiences_offered { get; set; }
        public string neighborhood_overview { get; set; }
        public string notes { get; set; }
        public string transit { get; set; }
        public string thumbnail_url { get; set; }
        public string medium_url { get; set; }
        public string picture_url { get; set; }
        public string xl_picture_url { get; set; }
        public int host_id { get; set; }
        public string host_url { get; set; }
        public string host_name { get; set; }
        public DateTime? host_since { get; set; }
        public string host_location { get; set; }
        public string host_about { get; set; }
        public string host_response_time { get; set; }
        public string host_response_rate { get; set; }
        public string host_acceptance_rate { get; set; }
        public bool host_is_superhost { get; set; }
        public string host_thumbnail_url { get; set; }
        public string host_picture_url { get; set; }
        public string host_neighbourhood { get; set; }
        public int host_listings_count { get; set; }
        public int host_total_listings_count { get; set; }
        public string host_verifications { get; set; }
        public bool host_has_profile_pic { get; set; }
        public bool host_identity_verified { get; set; }
        public string street { get; set; }
        public string neighbourhood { get; set; }
        public string neighbourhood_cleansed { get; set; }
        public string neighbourhood_group_cleansed { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public string market { get; set; }
        public string smart_location { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public bool is_location_exact { get; set; }
        public string property_type { get; set; }
        public string room_type { get; set; }
        public int accommodates { get; set; }
        public double bathrooms { get; set; }
        public int bedrooms { get; set; }
        public int beds { get; set; }
        public string bed_type { get; set; }
        public string amenities { get; set; }
        public string square_feet { get; set; }
        public string price { get; set; }
        public string weekly_price { get; set; }
        public string monthly_price { get; set; }
        public string security_deposit { get; set; }
        public string cleaning_fee { get; set; }
        public int guests_included { get; set; }
        public string extra_people { get; set; }
        public int minimum_nights { get; set; }
        public int maximum_nights { get; set; }
        public string calendar_updated { get; set; }
        public string has_availability { get; set; }
        public int availability_30 { get; set; }
        public int availability_60 { get; set; }
        public int availability_90 { get; set; }
        public int availability_365 { get; set; }
        public DateTime? calendar_last_scraped { get; set; }
        public int number_of_reviews { get; set; }
        public DateTime? first_review { get; set; }
        public DateTime? last_review { get; set; }
        public int review_scores_rating { get; set; }
        public int review_scores_accuracy { get; set; }
        public int review_scores_cleanliness { get; set; }
        public int review_scores_checkin { get; set; }
        public int review_scores_communication { get; set; }
        public int review_scores_location { get; set; }
        public int review_scores_value { get; set; }
        public string requires_license { get; set; }
        public string license { get; set; }
        public string jurisdiction_names { get; set; }
        public string instant_bookable { get; set; }
        public string cancellation_policy { get; set; }
        public string require_guest_profile_picture { get; set; }
        public string require_guest_phone_verification { get; set; }
        public int calculated_host_listings_count { get; set; }
        public double reviews_per_month { get; set; }
    }
}

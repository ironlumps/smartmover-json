using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMoverJSON
{
    public class Rootobject
    {
        public string CASSReportLink { get; set; }
        public string NCOAReportLink { get; set; }
        public Record[] Records { get; set; }
        public string TotalRecords { get; set; }
        public string TransmissionReference { get; set; }
        public string TransmissionResults { get; set; }
        public string Version { get; set; }
    }

    public class Record
    {
        public string AddressDeliveryInstallation { get; set; }
        public string AddressExtras { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressKey { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLockBox { get; set; }
        public string AddressPostDirection { get; set; }
        public string AddressPreDirection { get; set; }
        public string AddressPrivateMailboxName { get; set; }
        public string AddressPrivateMailboxRange { get; set; }
        public string AddressRouteService { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressStreetSuffix { get; set; }
        public string AddressSuiteName { get; set; }
        public string AddressSuiteNumber { get; set; }
        public string AddressTypeCode { get; set; }
        public string BaseMelissaAddressKey { get; set; }
        public string CarrierRoute { get; set; }
        public string City { get; set; }
        public string CityAbbreviation { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string DPVFootNotes { get; set; }
        public string DeliveryIndicator { get; set; }
        public string DeliveryPointCheckDigit { get; set; }
        public string DeliveryPointCode { get; set; }
        public string MelissaAddressKey { get; set; }
        public string MoveEffectiveDate { get; set; }
        public string MoveReturnCode { get; set; }
        public string MoveTypeCode { get; set; }
        public string NameFirst { get; set; }
        public string NameFull { get; set; }
        public string NameLast { get; set; }
        public string NameMiddle { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string OriginalAddressLine1 { get; set; }
        public string OriginalAddressLine2 { get; set; }
        public string OriginalCity { get; set; }
        public string OriginalCityAbbreviation { get; set; }
        public string OriginalCountryCode { get; set; }
        public string OriginalPlus4 { get; set; }
        public string OriginalPostalCode { get; set; }
        public string OriginalPrivateMailbox { get; set; }
        public string OriginalResults { get; set; }
        public string OriginalState { get; set; }
        public string OriginalStateName { get; set; }
        public string OriginalSuite { get; set; }
        public string OriginalUrbanization { get; set; }
        public string Plus4 { get; set; }
        public string PostalCode { get; set; }
        public string PrivateMailbox { get; set; }
        public string RecordID { get; set; }
        public string Results { get; set; }
        public string StandardizedAddressLine1 { get; set; }
        public string StandardizedAddressLine2 { get; set; }
        public string StandardizedBaseMelissaAddressKey { get; set; }
        public string StandardizedCarrierRoute { get; set; }
        public string StandardizedCity { get; set; }
        public string StandardizedCityAbbreviation { get; set; }
        public string StandardizedCountryCode { get; set; }
        public string StandardizedDeliveryIndicator { get; set; }
        public string StandardizedDeliveryPointCheckDigit { get; set; }
        public string StandardizedDeliveryPointCode { get; set; }
        public string StandardizedMelissaAddressKey { get; set; }
        public string StandardizedPlus4 { get; set; }
        public string StandardizedPostalCode { get; set; }
        public string StandardizedPrivateMailbox { get; set; }
        public string StandardizedResults { get; set; }
        public string StandardizedState { get; set; }
        public string StandardizedStateName { get; set; }
        public string StandardizedSuite { get; set; }
        public string StandardizedUrbanization { get; set; }
        public string State { get; set; }
        public string StateName { get; set; }
        public string Suite { get; set; }
        public string Urbanization { get; set; }


        public override string ToString()
        {
            return "Name: " + NamePrefix + " " + NameFull + " " + NameSuffix + Environment.NewLine +
            "Address Line 1: " + AddressLine1 + Environment.NewLine +
            "Address Line 2: " + AddressLine2 + Environment.NewLine +
            "Address Key: " + AddressKey + Environment.NewLine +
            "Melissa Address Key: " + MelissaAddressKey + Environment.NewLine +
            "City: " + CityAbbreviation + " - " + City + Environment.NewLine +
            "Postal Code: " + PostalCode + Environment.NewLine +
            "State: " + State + " - " + StateName + Environment.NewLine +
            "Country: " + CountryCode + " - " + CountryName + Environment.NewLine +
            "Move Date: " + MoveEffectiveDate + Environment.NewLine +
            "Results: " + Results + Environment.NewLine;

        }

        public string TransmissionReference { get; set; }
        public string CustomerID { get; set; }
        public string Options { get; set; }
        public Record[] Records { get; set; }

       

        public Record(String recID, String firstName, String lastName, String emailAddress, String address, String city, String state, String zip, String phone)
        {

        }
    

    }
}

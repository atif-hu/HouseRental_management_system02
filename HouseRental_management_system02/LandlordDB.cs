using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRental_management_system02
{
    public class LandlordDB
    {
        public static List<Landlord> GetLandlords()
        {
            List<Landlord> landlords = new List<Landlord>()
            {
                new Landlord(){landlordId=0,LandlordName="Aman",houseDetails="2bhk",Rent=20000,Address="Toli chowki ,Hyderabad"},
                new Landlord(){landlordId=1,LandlordName="Akaash",houseDetails="3bhk",Rent=25000,Address="Kolkata"},
                new Landlord(){landlordId=2,LandlordName="Yash",houseDetails="1bhk",Rent=10000,Address="Dhanbad"},
                new Landlord(){landlordId=3,LandlordName="Shrujan",houseDetails="2bhk",Rent=15000,Address="Mumbai"},
                new Landlord(){landlordId=4,LandlordName="Anamika",houseDetails="3bhk",Rent=21000,Address="Hyderabad"},
                new Landlord(){landlordId=5,LandlordName="Vaibhav",houseDetails="4bhk",Rent=30000,Address="Patna"}
            };
            return landlords;
        }
    }
}

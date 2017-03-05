using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Steam4NET;

namespace SteamBulkActivator
{
    public class Utils
    {
        public static Random Random = new Random();

        public static string GetTimestamp()
        {
            return DateTime.Now.ToString("d-M-yyyy HH-mm-ss");
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string GetRandomCDKey()
        {
            return $"{RandomString(5)}-{RandomString(5)}-{RandomString(5)}";
        }

        public static bool ValidateCDKey(string pchActivationCode)
        {
            /*Example match: ABCDE-ABCDE-ABCDE*/
            return new Regex("([A-Z0-9]{5}-[A-Z0-9]{5}-[A-Z0-9]{5})").IsMatch(pchActivationCode);
        }

        public static string GetFriendlyEPurchaseResultDetailMsg(int result)
        {
            EPurchaseResultDetail e = (EPurchaseResultDetail)result;

            switch(e)
            {
                case EPurchaseResultDetail.k_EPurchaseResultNoDetail:
                    return "Success";

                case EPurchaseResultDetail.k_EPurchaseResultAlreadyPurchased:
                    return "Already registered";

                case EPurchaseResultDetail.k_EPurchaseResultRestrictedCountry:
                    return "Key restricted country";

                case EPurchaseResultDetail.k_EPurchaseResultBadActivationCode:
                    return "Bad activation key";

                case EPurchaseResultDetail.k_EPurchaseResultDuplicateActivationCode:
                    return "Duplicate activation code";

                case EPurchaseResultDetail.k_EPurchaseResultRegionNotSupported:
                    return "Region not supported";

                case EPurchaseResultDetail.k_EPurchaseResultInvalidAccount:
                    return "Invalid account";

                case EPurchaseResultDetail.k_EPurchaseResultDoesNotOwnRequiredApp:
                    return "Does not own required app to register this key";

                default:
                    switch (result)
                    {
                        case 53:
                            return "Too many activation attempts";

                        default:
                            return e.ToString();
                    }
            }
        }
    }
}

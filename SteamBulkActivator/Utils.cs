using System;
using System.Linq;
using System.Text.RegularExpressions;
using Steam4NET;

namespace SteamBulkActivator
{
    public class Utils
    {
        public static Random Random = new Random();

        public static string GetTimestamp()
        {
            return DateTime.Now.ToString("yyyy-M-d HH-mm-ss");
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

        public static string GetFriendlyEPurchaseResultDetailMsg(EPurchaseResultDetail result)
        {
            switch(result)
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

                case EPurchaseResultDetail.k_EPurchaseResultTooManyActivationAttempts:
                    return "Too many activation attempts. Try again later.";

                default:
                    return result.ToString();
            }
        }
    }
}

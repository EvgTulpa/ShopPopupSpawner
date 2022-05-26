using System.Collections.Generic;
using trackers;

namespace Murka
{
    public class ShopPopupSpawnerUtil
    {
        public static void OpenShopPopup(ShopPopupSpawnerData data)
        {
            bool isCoinPage = data.IsCoinsPage;
            
            Dictionary<string, object> payload = BuyPopupHelper.AddBuyPopup(data.Reason, isCoinPage ? 1 : 2, 0);
            OpenSlotTracker.AddReason(payload);
            AdditionalTrackersParams.AddSaleGrope("buy_menu",payload);
            AdditionalTrackersParams.AddSaleMechanics("buy_menu",payload);
            
            string promoType = OfferManager.Instance.GetActiveBuyMenuReskin() ?? "base";
            string moneyType = isCoinPage ? "coins" : "gems";
            string moneyTrackerType = isCoinPage ? StoreTrackers.STORE_OPEN_COINS : StoreTrackers.STORE_OPEN_GEMS;
            if (isCoinPage)
            {
                BillsTrackers.Instance.AddReason(payload);
            }

            AdditionalTrackersParams.AddPriceList<DefaultPriceListWithSubscriptionGenerator, List<PriceVO>>(moneyType, promoType, payload);
            MurkaCore.Instance.Tracker.track(new TrackerVO(moneyTrackerType, string.Empty, payload));
        }
    }
}

using System.Collections.Generic;
using trackers;

namespace Murka
{
    public class ShopPopupSpawnerUtil
    {
        public static void OpenShopPopup(ShopPopupSpawnerData data)
        {
            Dictionary<string, object> payload = BuyPopupHelper.AddBuyPopup(data.Reason, data.Page, 0);
            OpenSlotTracker.AddReason(payload);
            AdditionalTrackersParams.AddSaleGrope("buy_menu",payload);
            AdditionalTrackersParams.AddSaleMechanics("buy_menu",payload);
            string promoType = OfferManager.Instance.GetActiveBuyMenuReskin() ?? "base";
            if (data.Page == 1)
            {
                BillsTrackers.Instance.AddReason(payload);
                AdditionalTrackersParams
                    .AddPriceList<DefaultPriceListWithSubscriptionGenerator, List<PriceVO>>("coins", promoType, payload);
                MurkaCore.Instance.Tracker.track(new TrackerVO(StoreTrackers.STORE_OPEN_COINS, "", payload));
                return;
            }

            AdditionalTrackersParams.AddPriceList<DefaultPriceListWithSubscriptionGenerator, List<PriceVO>>("gems", promoType, payload);
            MurkaCore.Instance.Tracker.track(new TrackerVO(StoreTrackers.STORE_OPEN_GEMS, "", payload));
        }
    }
}
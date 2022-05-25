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
            bool isCoinPage = page == 1;
            string moneyType = isCoinPage ? "coins" : "gems";
            string moneyTrackerType = isCoinPage ? StoreTrackers.STORE_OPEN_COINS : StoreTrackers.STORE_OPEN_GEMS;
            if (isCoinPage)
            {
                BillsTrackers.Instance.AddReason(payload);
            }

            AdditionalTrackersParams.AddPriceList<DefaultPriceListWithSubscriptionGenerator, List<PriceVO>>(moneyType, promoType, payload);
            MurkaCore.Instance.Tracker.track(new TrackerVO(moneyTrackerType, string.Empty, payload));
        }
        
        public static void OpenShopPopup(ShopPopupSpawnerData data)
        {
            bool isCoinPage = data.CoinsPage;
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
        
        public static void OpenShopPopup(ShopPopupSpawnerData data)
        {
            bool isCoinPage = data.IsCoinPage();
            
            Dictionary<string, object> payload = BuyPopupHelper.AddBuyPopup(data.Reason, isCoinPage ? 1 : 2, 0);
            OpenSlotTracker.AddReason(payload);
            AdditionalTrackersParams.AddSaleGrope("buy_menu",payload);
            AdditionalTrackersParams.AddSaleMechanics("buy_menu",payload);
            
            string promoType = OfferManager.Instance.GetActiveBuyMenuReskin() ?? "base";
            string moneyTrackerType = isCoinPage ? StoreTrackers.STORE_OPEN_COINS : StoreTrackers.STORE_OPEN_GEMS;
            if (isCoinPage)
            {
                BillsTrackers.Instance.AddReason(payload);
            }

            AdditionalTrackersParams.AddPriceList<DefaultPriceListWithSubscriptionGenerator, List<PriceVO>>(data.PageType, promoType, payload);
            MurkaCore.Instance.Tracker.track(new TrackerVO(moneyTrackerType, string.Empty, payload));
        }
    }
}

using UnityEngine;

namespace Murka
{
    public class ShopPopupSpawnerViewComponent : MonoBehaviour
    {
        [SerializeField] private ShopPopupSpawnerData ShopPopupSpawnerData;

        public void SetReason(string value)
        {
            ShopPopupSpawnerData.Reason = value;
        }
        
        public void SetCoinPage()
        {
            ShopPopupSpawnerData.IsCoinsPage = true;
        }
        
        public void SetGemsPage()
        {
            ShopPopupSpawnerData.IsCoinsPage = false;
        }

        public void OpenShopPopup()
        {
            ShopPopupSpawnerUtil.OpenShopPopup(ShopPopupSpawnerData);
        }
    }
}

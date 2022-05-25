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
        
        public void SetPage(int value)
        {
            ShopPopupSpawnerData.Page = value;
        }

        public void OpenShopPopup()
        {
            ShopPopupSpawnerUtil.OpenShopPopup(ShopPopupSpawnerData);
        }
    }
}

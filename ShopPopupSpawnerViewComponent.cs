using UnityEngine;

namespace Murka
{
    public class ShopPopupSpawnerViewComponent : MonoBehaviour
    {
        [SerializeField] private ShopPopupSpawnerData ShopPopupSpawnerData;

        public void OpenShopPopup()
        {
            ShopPopupSpawnerUtil.OpenShopPopup(ShopPopupSpawnerData);
        }
    }
}
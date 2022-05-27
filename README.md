# Example:
<b>Instead of this:</b>
```c#
TopPanelController.Instance.ShopButton.SimulateClick();
```
<b>We do this</b><br>
Using as ViewComponent in inspector.<br><br>

![2](https://user-images.githubusercontent.com/103635242/170462057-77afc436-b72f-4afa-8409-3dd4e646d9f0.png)

```c#
public class A : MonoBehaviour
{
  [SerializeField] private ShopPopupSpawnerViewComponent ShopPopupSpawnerViewComponent;

  private void SomeMethod()
  {
      ShopPopupSpawnerViewComponent.OpenShopPopup();
  }
}
```

Using as c# class.<br>
```c#
public class B
{
  private int PlayerCoins;

  private void SomeMethod()
  {
      ShopPopupSpawnerData data = new ShopPopupSpawnerData
      {
          Reason = PlayerCoins > 0 ? "rich" : "poor",
          IsCoinsPage = PlayerCoins > 0
      };
      ShopPopupSpawnerUtil.OpenShopPopup(data);
  }
}
```

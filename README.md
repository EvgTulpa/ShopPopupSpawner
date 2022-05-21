# Example:
Using as ViewComponent in inspector.<br>

![1](https://user-images.githubusercontent.com/103635242/169654570-8ad15514-ebae-41d5-ae45-12bbd7775be5.png)

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
<br>
Using as regular c# class.<br>
```c#
public class B
{
  private int PlayerCoins;

  private void SomeMethod()
  {
      ShopPopupSpawnerData data = new ShopPopupSpawnerData(){Reason = PlayerCoins > 0 ? "rich" : "noMoney", Page = PlayerCoins > 0 ? 1 : 0}
  }
}
```

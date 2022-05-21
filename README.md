# Example:
Class A and B from different sytems starts asynchronously. You do not know wich object will start first, but you need to pass some data from A to B.
In this example the data by key "coinsContainer" will not be setted, but the "playerCoins" will be received.
If object A (data sender) will be created first, the object B (data receiver) still will receive the data after it will be added to GlobalObserver, because of DeferredData.<br>
<i>GlobalObserver.Instance.RemoveData</i> methods is recommended, because object A doesn`t know if object B will be created, so A need to try cleanup his data before it destruction.

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

```c#
public class B
{
  private int _playerCoins;

  private void SomeMethod()
  {
      ShopPopupSpawnerData data = new ShopPopupSpawnerData(){Reason = PlayerCoins > 0 ? "rich" : "noMoney", Page = PlayerCoins > 0 ? 1 : 0}
  }
}
```

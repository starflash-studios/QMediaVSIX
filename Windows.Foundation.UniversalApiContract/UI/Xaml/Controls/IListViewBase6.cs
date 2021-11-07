// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ListViewBase))]
  [Guid(4171507255, 38491, 18491, 148, 229, 229, 201, 254, 240, 227, 82)]
  [WebHostHidden]
  internal interface IListViewBase6
  {
    [RemoteAsync]
    IAsyncOperation<bool> TryStartConnectedAnimationAsync(
      ConnectedAnimation animation,
      object item,
      string elementName);

    ConnectedAnimation PrepareConnectedAnimation(
      string key,
      object item,
      string elementName);
  }
}

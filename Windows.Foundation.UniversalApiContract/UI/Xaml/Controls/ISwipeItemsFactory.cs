// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItemsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SwipeItems))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1204052206, 54698, 17503, 179, 30, 80, 192, 118, 192, 17, 185)]
  internal interface ISwipeItemsFactory
  {
    SwipeItems CreateInstance(object baseInterface, out object innerInterface);
  }
}

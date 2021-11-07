// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItemInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwipeItemInvokedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3316655605, 52018, 18227, 128, 17, 93, 13, 55, 244, 85, 10)]
  internal interface ISwipeItemInvokedEventArgs
  {
    SwipeControl SwipeControl { get; }
  }
}

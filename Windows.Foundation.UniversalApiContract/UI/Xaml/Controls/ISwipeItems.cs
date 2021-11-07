// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItems
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(2954307327, 38554, 16592, 159, 4, 118, 8, 76, 230, 215, 183)]
  [ExclusiveTo(typeof (SwipeItems))]
  internal interface ISwipeItems
  {
    SwipeMode Mode { get; set; }
  }
}

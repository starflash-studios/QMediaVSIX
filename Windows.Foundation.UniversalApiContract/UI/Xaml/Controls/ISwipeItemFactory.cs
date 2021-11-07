// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwipeItem))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2219562522, 5910, 16535, 187, 162, 117, 38, 218, 34, 222, 57)]
  [WebHostHidden]
  internal interface ISwipeItemFactory
  {
    SwipeItem CreateInstance(object baseInterface, out object innerInterface);
  }
}

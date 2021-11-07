// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3850037308, 8726, 18199, 158, 246, 70, 98, 51, 76, 101, 1)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SwipeControl))]
  internal interface ISwipeControlStatics
  {
    DependencyProperty LeftItemsProperty { get; }

    DependencyProperty RightItemsProperty { get; }

    DependencyProperty TopItemsProperty { get; }

    DependencyProperty BottomItemsProperty { get; }
  }
}

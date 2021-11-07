// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlipViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1893980479, 17160, 19362, 187, 206, 226, 203, 14, 211, 68, 118)]
  [ExclusiveTo(typeof (FlipView))]
  [WebHostHidden]
  internal interface IFlipViewStatics2
  {
    DependencyProperty UseTouchAnimationsForAllNavigationProperty { get; }
  }
}

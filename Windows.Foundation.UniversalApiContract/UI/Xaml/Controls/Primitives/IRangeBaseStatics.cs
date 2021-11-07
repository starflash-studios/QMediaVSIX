// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRangeBaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1743722465, 65079, 18255, 158, 151, 59, 94, 11, 48, 242, 224)]
  [ExclusiveTo(typeof (RangeBase))]
  [WebHostHidden]
  internal interface IRangeBaseStatics
  {
    DependencyProperty MinimumProperty { get; }

    DependencyProperty MaximumProperty { get; }

    DependencyProperty SmallChangeProperty { get; }

    DependencyProperty LargeChangeProperty { get; }

    DependencyProperty ValueProperty { get; }
  }
}

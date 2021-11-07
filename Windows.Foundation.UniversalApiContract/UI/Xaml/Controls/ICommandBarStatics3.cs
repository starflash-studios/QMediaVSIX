// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3025806500, 35569, 18499, 179, 25, 224, 63, 196, 90, 183, 38)]
  [ExclusiveTo(typeof (CommandBar))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICommandBarStatics3
  {
    DependencyProperty DefaultLabelPositionProperty { get; }

    DependencyProperty OverflowButtonVisibilityProperty { get; }

    DependencyProperty IsDynamicOverflowEnabledProperty { get; }
  }
}

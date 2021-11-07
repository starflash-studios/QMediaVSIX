// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTipStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4026697144, 19369, 20303, 134, 167, 134, 0, 56, 19, 206, 179)]
  [ExclusiveTo(typeof (ToolTip))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToolTipStatics
  {
    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty IsOpenProperty { get; }

    DependencyProperty PlacementProperty { get; }

    DependencyProperty PlacementTargetProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [Guid(4267356054, 31017, 19873, 170, 103, 205, 223, 115, 163, 228, 181)]
  [WebHostHidden]
  internal interface IAppBarToggleButtonStatics
  {
    DependencyProperty LabelProperty { get; }

    DependencyProperty IconProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}

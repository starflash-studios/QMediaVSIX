// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [Guid(2493387791, 52863, 20033, 189, 197, 209, 211, 56, 138, 208, 166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IComboBoxStatics3
  {
    DependencyProperty LightDismissOverlayModeProperty { get; }

    DependencyProperty IsTextSearchEnabledProperty { get; }
  }
}

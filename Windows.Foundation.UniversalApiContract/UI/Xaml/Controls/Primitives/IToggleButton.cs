// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ToggleButton))]
  [WebHostHidden]
  [Guid(1486387195, 4039, 16438, 157, 139, 18, 125, 250, 117, 193, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToggleButton
  {
    IReference<bool> IsChecked { get; set; }

    bool IsThreeState { get; set; }

    event RoutedEventHandler Checked;

    event RoutedEventHandler Unchecked;

    event RoutedEventHandler Indeterminate;
  }
}

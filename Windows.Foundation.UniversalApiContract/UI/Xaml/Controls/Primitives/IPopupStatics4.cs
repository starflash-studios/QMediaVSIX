// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopupStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (Popup))]
  [Guid(3517197318, 35834, 20836, 133, 84, 72, 191, 230, 189, 76, 198)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  internal interface IPopupStatics4
  {
    DependencyProperty PlacementTargetProperty { get; }

    DependencyProperty DesiredPlacementProperty { get; }
  }
}

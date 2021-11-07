// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(2200460366, 6134, 19107, 182, 27, 232, 124, 113, 134, 4, 234)]
  [ExclusiveTo(typeof (ComboBoxTemplateSettings))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxTemplateSettings
  {
    double DropDownOpenedHeight { get; }

    double DropDownClosedHeight { get; }

    double DropDownOffset { get; }

    AnimationDirection SelectedItemDirection { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ComboBoxTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(15273175, 26814, 17565, 181, 167, 118, 226, 111, 112, 62, 155)]
  [WebHostHidden]
  internal interface IComboBoxTemplateSettings2
  {
    double DropDownContentMinWidth { get; }
  }
}

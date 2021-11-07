// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePicker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3140007029, 11295, 17216, 158, 48, 148, 143, 153, 201, 229, 122)]
  internal interface IDatePicker2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}

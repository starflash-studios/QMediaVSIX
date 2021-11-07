// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISlider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1084474638, 34774, 19759, 177, 207, 178, 121, 204, 153, 111, 38)]
  [ExclusiveTo(typeof (Slider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISlider2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }
  }
}

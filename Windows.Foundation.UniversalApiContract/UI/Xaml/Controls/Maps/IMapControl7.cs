// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(226944083, 3103, 20350, 174, 102, 74, 208, 180, 152, 120, 87)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MapControl))]
  internal interface IMapControl7
  {
    string Region { get; set; }
  }
}

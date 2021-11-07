// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapControl))]
  [Guid(1482893560, 36061, 16558, 147, 56, 175, 42, 123, 232, 69, 229)]
  internal interface IMapControl3
  {
    event TypedEventHandler<MapControl, MapRightTappedEventArgs> MapRightTapped;
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRightTappedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRightTappedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(546582897, 28648, 16550, 173, 14, 41, 115, 121, 181, 117, 167)]
  internal interface IMapRightTappedEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }
  }
}

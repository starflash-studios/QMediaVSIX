// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapBillboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapBillboard))]
  [WebHostHidden]
  [Guid(378807709, 2786, 20290, 160, 46, 41, 44, 168, 53, 211, 157)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapBillboard
  {
    Geopoint Location { get; set; }

    Point NormalizedAnchorPoint { get; set; }

    IRandomAccessStreamReference Image { get; set; }

    MapElementCollisionBehavior CollisionBehaviorDesired { get; set; }

    MapCamera ReferenceCamera { get; }
  }
}

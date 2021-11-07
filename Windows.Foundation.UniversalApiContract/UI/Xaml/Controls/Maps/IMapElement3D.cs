// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElement3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(2189097173, 14403, 18658, 189, 0, 15, 6, 68, 251, 230, 165)]
  [ExclusiveTo(typeof (MapElement3D))]
  internal interface IMapElement3D
  {
    Geopoint Location { get; set; }

    MapModel3D Model { get; set; }

    double Heading { get; set; }

    double Pitch { get; set; }

    double Roll { get; set; }

    Vector3 Scale { get; set; }
  }
}

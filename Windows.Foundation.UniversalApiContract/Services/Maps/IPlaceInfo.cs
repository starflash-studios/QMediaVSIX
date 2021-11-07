// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IPlaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (PlaceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2584219830, 12744, 20330, 159, 24, 149, 11, 76, 56, 149, 26)]
  internal interface IPlaceInfo
  {
    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPreferredPlacement")]
    void Show(Rect selection, Placement preferredPlacement);

    string Identifier { get; }

    string DisplayName { get; }

    string DisplayAddress { get; }

    IGeoshape Geoshape { get; }
  }
}

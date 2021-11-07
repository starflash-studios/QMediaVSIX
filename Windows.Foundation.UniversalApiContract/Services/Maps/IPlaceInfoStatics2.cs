// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IPlaceInfoStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(1930363465, 16455, 17571, 143, 129, 37, 80, 165, 33, 99, 112)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PlaceInfo))]
  internal interface IPlaceInfoStatics2
  {
    [Overload("CreateFromAddress")]
    PlaceInfo CreateFromAddress(string displayAddress);

    [Overload("CreateFromAddressWithName")]
    PlaceInfo CreateFromAddress(string displayAddress, string displayName);
  }
}

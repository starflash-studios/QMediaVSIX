// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [Guid(1868163090, 30, 18500, 188, 198, 67, 40, 134, 133, 106, 23)]
  [ExclusiveTo(typeof (PnpObjectUpdate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPnpObjectUpdate
  {
    PnpObjectType Type { get; }

    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }
  }
}

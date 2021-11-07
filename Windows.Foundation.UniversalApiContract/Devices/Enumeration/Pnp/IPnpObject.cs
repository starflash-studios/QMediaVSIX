// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ExclusiveTo(typeof (PnpObject))]
  [Guid(2512806488, 29499, 19087, 147, 163, 219, 7, 138, 200, 112, 193)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPnpObject
  {
    PnpObjectType Type { get; }

    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }

    void Update(PnpObjectUpdate updateInfo);
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ILanIdentifierData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (LanIdentifierData))]
  [Guid(2806940611, 54841, 17854, 163, 106, 196, 228, 174, 175, 109, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanIdentifierData
  {
    uint Type { get; }

    IVectorView<byte> Value { get; }
  }
}

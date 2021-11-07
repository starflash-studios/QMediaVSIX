// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (NetworkUsage))]
  [Guid(1239060430, 39301, 18727, 191, 91, 7, 43, 92, 101, 248, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkUsage
  {
    ulong BytesSent { get; }

    ulong BytesReceived { get; }

    TimeSpan ConnectionDuration { get; }
  }
}

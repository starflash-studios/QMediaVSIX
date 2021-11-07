// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimDiscoverEvent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3852125155, 14780, 24431, 147, 33, 13, 74, 24, 45, 38, 27)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (ESimDiscoverEvent))]
  internal interface IESimDiscoverEvent
  {
    string MatchingId { get; }

    string RspServerAddress { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (ProximityMessage))]
  [Guid(4020963202, 63201, 18037, 160, 69, 216, 227, 32, 194, 72, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximityMessage
  {
    string MessageType { get; }

    long SubscriptionId { get; }

    IBuffer Data { get; }

    string DataAsString { get; }
  }
}

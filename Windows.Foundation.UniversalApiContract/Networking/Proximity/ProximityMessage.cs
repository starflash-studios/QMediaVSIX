// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ProximityMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  /// <summary>Represents a message that's received from a subscription.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProximityMessage : IProximityMessage
  {
    /// <summary>Gets the type of the message.</summary>
    /// <returns>The type of the message.</returns>
    public extern string MessageType { [MethodImpl] get; }

    /// <summary>Gets the subscription ID of the message.</summary>
    /// <returns>The subscription ID of the message.</returns>
    public extern long SubscriptionId { [MethodImpl] get; }

    /// <summary>Gets the binary data of the message.</summary>
    /// <returns>The binary data of the message.</returns>
    public extern IBuffer Data { [MethodImpl] get; }

    /// <summary>Gets the message data as text.</summary>
    /// <returns>The message data as text.</returns>
    public extern string DataAsString { [MethodImpl] get; }
  }
}

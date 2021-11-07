// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>The ConnectionSession class is used to represent a connection to an access point established with AcquireConnectionAsync.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConnectionSession : IConnectionSession, IClosable
  {
    /// <summary>Retrieves the ConnectionProfile associated with the connection session.</summary>
    /// <returns>The connection profile used to define the properties of the access point connection.</returns>
    public extern ConnectionProfile ConnectionProfile { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}

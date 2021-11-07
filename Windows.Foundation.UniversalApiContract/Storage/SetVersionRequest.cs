// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SetVersionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides data when an app sets the version of the application data in its app data store.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SetVersionRequest : ISetVersionRequest
  {
    /// <summary>Gets the current version.</summary>
    /// <returns>The current version.</returns>
    public extern uint CurrentVersion { [MethodImpl] get; }

    /// <summary>Gets the requested version.</summary>
    /// <returns>The requested version.</returns>
    public extern uint DesiredVersion { [MethodImpl] get; }

    /// <summary>Requests that the set version request be delayed.</summary>
    /// <returns>The set version deferral.</returns>
    [MethodImpl]
    public extern SetVersionDeferral GetDeferral();
  }
}

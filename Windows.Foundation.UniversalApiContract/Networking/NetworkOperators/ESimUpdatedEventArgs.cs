// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides data for the ESimWatcher.Updated event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ESimUpdatedEventArgs : IESimUpdatedEventArgs
  {
    /// <summary>Gets the ESim instance that was updated.</summary>
    /// <returns>The ESim instance that was updated.</returns>
    public extern ESim ESim { [MethodImpl] get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemIdentificationInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  /// <summary>Represents a unique system identifier based on either the app publisher ID or a user ID.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SystemIdentificationInfo : ISystemIdentificationInfo
  {
    /// <summary>Gets a unique system identifier based on either the app publisher ID or a user ID.</summary>
    /// <returns>A unique system identifier based on either the app publisher ID or a user ID.</returns>
    public extern IBuffer Id { [MethodImpl] get; }

    /// <summary>Gets the source that generated the unique ID, either a Unified Extensible Firmware Interface (UEFI) or a Trusted Platform Module (TPM).</summary>
    /// <returns>The source that generated the unique ID.</returns>
    public extern SystemIdentificationSource Source { [MethodImpl] get; }
  }
}

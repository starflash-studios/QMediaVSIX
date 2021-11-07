// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimDownloadProfileMetadataResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents the outcome of an operation to download eSIM profile installation metadata (the result of the operation, and any installation metadata that was downloaded).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ESimDownloadProfileMetadataResult : IESimDownloadProfileMetadataResult
  {
    /// <summary>Gets the result of an operation to download eSIM profile installation metadata.</summary>
    /// <returns>The result of an operation to download eSIM profile installation metadata.</returns>
    public extern ESimOperationResult Result { [MethodImpl] get; }

    /// <summary>Gets an object representing any eSIM profile installation metadata that was downloaded.</summary>
    /// <returns>An object representing the eSIM profile installation metadata that was downloaded, or `null` if the download operation did not succeed.</returns>
    public extern ESimProfileMetadata ProfileMetadata { [MethodImpl] get; }
  }
}

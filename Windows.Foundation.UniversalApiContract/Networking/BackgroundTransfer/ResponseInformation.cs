// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.ResponseInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents data that is returned by a server response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResponseInformation : IResponseInformation
  {
    /// <summary>Gets a value that specifies whether the download is resumable.</summary>
    /// <returns>This property returns true if a download is resumable; otherwise false is returned.</returns>
    public extern bool IsResumable { [MethodImpl] get; }

    /// <summary>Gets the URI that contains the requested data.</summary>
    /// <returns>The URI that contains the requested data.</returns>
    public extern Uri ActualUri { [MethodImpl] get; }

    /// <summary>Gets the status code returned by the server.</summary>
    /// <returns>The status code returned by the server.</returns>
    public extern uint StatusCode { [MethodImpl] get; }

    /// <summary>Gets all response headers sent by the server.</summary>
    /// <returns>Contains all response headers sent by the server.</returns>
    public extern IMapView<string, string> Headers { [MethodImpl] get; }
  }
}

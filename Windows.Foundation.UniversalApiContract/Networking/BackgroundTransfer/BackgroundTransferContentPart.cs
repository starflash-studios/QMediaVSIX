// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents a content part of a multi-part transfer request. Each BackgroundTransferContentPart object can represent either a single string of text content or a single file payload, but not both.</summary>
  [Activatable(typeof (IBackgroundTransferContentPartFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BackgroundTransferContentPart : IBackgroundTransferContentPart
  {
    /// <summary>Creates a BackgroundTransferContentPart object that identifies the content it represents.</summary>
    /// <param name="name">Identifies the content.</param>
    [MethodImpl]
    public extern BackgroundTransferContentPart(string name);

    /// <summary>Creates a BackgroundTransferContentPart object that identifies the file content and the name of the file that it represents.</summary>
    /// <param name="name">Identifies the content.</param>
    /// <param name="fileName">The fully qualified file name, including the local path.</param>
    [MethodImpl]
    public extern BackgroundTransferContentPart(string name, string fileName);

    /// <summary>Creates a BackgroundTransferContentPart object.</summary>
    [MethodImpl]
    public extern BackgroundTransferContentPart();

    /// <summary>Sets content disposition header values that indicate the nature of the information that this BackgroundTransferContentPart represents.</summary>
    /// <param name="headerName">The header name.</param>
    /// <param name="headerValue">The header value.</param>
    [MethodImpl]
    public extern void SetHeader(string headerName, string headerValue);

    /// <summary>Use this method to set text information that the BackgroundTransferContentPart represents.</summary>
    /// <param name="value">A string value used to represent text information. (for example, api_sig, api_key, auth_token, etc...)</param>
    [MethodImpl]
    public extern void SetText(string value);

    /// <summary>Sets the source file for a BackgroundTransferContentPart containing the file for upload.</summary>
    /// <param name="value">The source file.</param>
    [MethodImpl]
    public extern void SetFile(IStorageFile value);
  }
}

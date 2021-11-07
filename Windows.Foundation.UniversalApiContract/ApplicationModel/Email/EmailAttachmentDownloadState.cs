// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailAttachmentDownloadState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the states of an email attachment download.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailAttachmentDownloadState
  {
    /// <summary>The attachment is not yet downloaded.</summary>
    NotDownloaded,
    /// <summary>The attachment is currently downloading.</summary>
    Downloading,
    /// <summary>The attachment has been downloaded.</summary>
    Downloaded,
    /// <summary>The attachment has failed.</summary>
    Failed,
  }
}

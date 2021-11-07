// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessageDownloadState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the download status of an email message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMessageDownloadState
  {
    /// <summary>The email message is partially downloaded.</summary>
    PartiallyDownloaded,
    /// <summary>The email message is currently downloading.</summary>
    Downloading,
    /// <summary>The download of the email message is complete.</summary>
    Downloaded,
    /// <summary>The download of the email message has failed.</summary>
    Failed,
  }
}

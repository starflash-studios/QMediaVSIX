// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessageSmimeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the S/MIME type of an email message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum EmailMessageSmimeKind
  {
    /// <summary>No MIME encryption or signature.</summary>
    None,
    /// <summary>Clear signed MIME (two MIME entities).</summary>
    ClearSigned,
    /// <summary>Opaque signed MIME (a single MIME entity).</summary>
    OpaqueSigned,
    /// <summary>Encrypted MIME.</summary>
    Encrypted,
  }
}

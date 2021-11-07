// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessageResponseKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the type of response to an email message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMessageResponseKind
  {
    /// <summary>The email message is not a response to another email message.</summary>
    None,
    /// <summary>The email message is a reply to the sender of another email message.</summary>
    Reply,
    /// <summary>The email message is a reply to the sender and all addressees of another email message.</summary>
    ReplyAll,
    /// <summary>The email message is a forwarded copy of another email message.</summary>
    Forward,
  }
}

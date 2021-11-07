// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQueryKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the type of email query.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailQueryKind
  {
    /// <summary>The query is for all email messages.</summary>
    All,
    /// <summary>The query is for email messages marked Important.</summary>
    Important,
    /// <summary>The query is for email messages that have been flagged.</summary>
    Flagged,
    /// <summary>The query is for all unread email messages.</summary>
    Unread,
    /// <summary>The query is for all email messages that have been read.</summary>
    Read,
    /// <summary>The query is for all email messages that have not yet been seen.</summary>
    Unseen,
  }
}

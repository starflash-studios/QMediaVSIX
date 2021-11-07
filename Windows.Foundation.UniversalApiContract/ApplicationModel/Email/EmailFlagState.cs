// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailFlagState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the flag state of an email message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailFlagState
  {
    /// <summary>The email has not been flagged for follow up.</summary>
    Unflagged,
    /// <summary>The email has been flagged for follow up.</summary>
    Flagged,
    /// <summary>The email was flagged for follow up and has been marked completed.</summary>
    Completed,
    /// <summary>The email was flagged for follow up and the flag has been cleared.</summary>
    Cleared,
  }
}

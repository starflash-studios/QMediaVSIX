// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxOtherAppReadAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines whether an application can read from a mailbox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxOtherAppReadAccess
  {
    /// <summary>Only system level applications can read from this mailbox.</summary>
    SystemOnly,
    /// <summary>All applications can read from this mailbox.</summary>
    Full,
    /// <summary>No other apps can read from this mailbox.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] None,
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryStoreAccessType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>The type of store you want to retrieve.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhoneCallHistoryStoreAccessType
  {
    /// <summary>Only entries created by this application should have read and write permissions.</summary>
    AppEntriesReadWrite,
    /// <summary>All of the entries should have limited read and write permissions.</summary>
    AllEntriesLimitedReadWrite,
    /// <summary>All the entries should have full read and write permissions.</summary>
    AllEntriesReadWrite,
  }
}

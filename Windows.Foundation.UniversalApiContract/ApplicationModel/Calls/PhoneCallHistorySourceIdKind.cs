// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistorySourceIdKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>The type of identifier that the PhoneCallHistoryEntry.SourceId refers to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhoneCallHistorySourceIdKind
  {
    /// <summary>The identifier is for a cellular phone line.</summary>
    CellularPhoneLineId,
    /// <summary>The identifier is for a family package.</summary>
    PackageFamilyName,
  }
}

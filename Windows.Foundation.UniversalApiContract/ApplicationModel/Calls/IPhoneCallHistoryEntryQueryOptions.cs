// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(2623529308, 35821, 16586, 176, 110, 196, 202, 142, 174, 92, 135)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryQueryOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhoneCallHistoryEntryQueryOptions
  {
    PhoneCallHistoryEntryQueryDesiredMedia DesiredMedia { get; set; }

    IVector<string> SourceIds { get; }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(821123546, 14677, 16450, 132, 230, 102, 238, 191, 130, 230, 127)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryAddress))]
  internal interface IPhoneCallHistoryEntryAddress
  {
    string ContactId { get; set; }

    string DisplayName { get; set; }

    string RawAddress { get; set; }

    PhoneCallHistoryEntryRawAddressKind RawAddressKind { get; set; }
  }
}
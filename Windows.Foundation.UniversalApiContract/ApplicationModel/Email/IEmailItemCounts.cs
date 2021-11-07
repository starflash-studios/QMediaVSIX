// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailItemCounts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1540436769, 65224, 19371, 131, 186, 11, 175, 60, 31, 108, 189)]
  [ExclusiveTo(typeof (EmailItemCounts))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailItemCounts
  {
    uint Flagged { get; }

    uint Important { get; }

    uint Total { get; }

    uint Unread { get; }
  }
}

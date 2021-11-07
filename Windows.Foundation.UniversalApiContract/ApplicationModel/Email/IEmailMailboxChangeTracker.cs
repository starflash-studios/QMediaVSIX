// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2061796920, 20838, 17079, 136, 130, 253, 33, 201, 43, 221, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMailboxChangeTracker))]
  internal interface IEmailMailboxChangeTracker
  {
    bool IsTracking { get; }

    void Enable();

    EmailMailboxChangeReader GetChangeReader();

    void Reset();
  }
}

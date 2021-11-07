// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageContentGroupStagingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageContentGroupStagingEventArgs))]
  [Guid(1031520894, 28455, 17516, 152, 110, 212, 115, 61, 77, 145, 19)]
  internal interface IPackageContentGroupStagingEventArgs
  {
    Guid ActivityId { get; }

    Package Package { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }

    string ContentGroupName { get; }

    bool IsContentGroupRequired { get; }
  }
}

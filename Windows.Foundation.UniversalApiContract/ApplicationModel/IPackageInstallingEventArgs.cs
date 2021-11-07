// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageInstallingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageInstallingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2540969655, 43898, 16410, 139, 97, 235, 14, 127, 175, 242, 55)]
  internal interface IPackageInstallingEventArgs
  {
    Guid ActivityId { get; }

    Package Package { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageUpdatingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3447407144, 64884, 17470, 177, 20, 35, 230, 119, 176, 232, 111)]
  internal interface IPackageUpdatingEventArgs
  {
    Guid ActivityId { get; }

    Package SourcePackage { get; }

    Package TargetPackage { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }
  }
}

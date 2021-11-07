// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageId))]
  [Guid(450586206, 14279, 18320, 153, 128, 221, 122, 231, 78, 139, 178)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageId
  {
    string Name { get; }

    PackageVersion Version { get; }

    ProcessorArchitecture Architecture { get; }

    string ResourceId { get; }

    string Publisher { get; }

    string PublisherId { get; }

    string FullName { get; }

    string FamilyName { get; }
  }
}

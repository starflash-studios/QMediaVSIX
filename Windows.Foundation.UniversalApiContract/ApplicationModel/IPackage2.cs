// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2791387062, 30344, 19150, 149, 251, 53, 149, 56, 231, 170, 1)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage2
  {
    string DisplayName { get; }

    string PublisherDisplayName { get; }

    string Description { get; }

    Uri Logo { get; }

    bool IsResourcePackage { get; }

    bool IsBundle { get; }

    bool IsDevelopmentMode { get; }
  }
}

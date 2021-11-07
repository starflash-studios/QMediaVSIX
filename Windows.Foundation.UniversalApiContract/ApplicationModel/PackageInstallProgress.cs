// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageInstallProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Gets the installation progress of installing a resource package or an app package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public struct PackageInstallProgress
  {
    /// <summary>The percent of the package that has been installed.</summary>
    public uint PercentComplete;
  }
}

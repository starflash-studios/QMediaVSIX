// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.StubPackageOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Defines the stub behavior for an app package that is being added or staged.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum StubPackageOption
  {
    /// <summary>Use the default behavior.</summary>
    Default,
    /// <summary>Install as a full app.</summary>
    InstallFull,
    /// <summary>Install as stub app.</summary>
    InstallStub,
    /// <summary>Use the current PackageSubPreference for the package.</summary>
    UsePreference,
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageStubPreference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Represents whether an app package currently prefers to run as a full app or a stub app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum PackageStubPreference
  {
    /// <summary>The app package currently prefers to run as a full app.</summary>
    Full,
    /// <summary>The app package currently prefers to run as a stub app.</summary>
    Stub,
  }
}

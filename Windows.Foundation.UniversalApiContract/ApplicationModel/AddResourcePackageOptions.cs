// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AddResourcePackageOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Specifies various options for adding a resource package to an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Flags]
  public enum AddResourcePackageOptions : uint
  {
    /// <summary>Downloads the specific package requested.</summary>
    None = 0,
    /// <summary>Restarts the application when resource packages are successfully added.</summary>
    ForceTargetAppShutdown = 1,
    /// <summary>Downloads all package updates if they are available.</summary>
    ApplyUpdateIfAvailable = 2,
  }
}

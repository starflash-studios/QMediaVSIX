// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Defines the different app install types that are returned by the InstallType property of the AppInstallItem class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppInstallType
  {
    /// <summary>The app is being installed.</summary>
    Install,
    /// <summary>The app is being updated.</summary>
    Update,
    /// <summary>The app installation is being repaired.</summary>
    Repair,
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageUpdateAvailability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>An enum that indicates if an application has an update, and if the update is required.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum PackageUpdateAvailability
  {
    /// <summary>This value is returned when this function is called on a package that does not have an AppInstaller file association.</summary>
    Unknown,
    /// <summary>This value is returned when no updates are available for the application.</summary>
    NoUpdates,
    /// <summary>This value is returned when an update for the application is available, and the update is not required.</summary>
    Available,
    /// <summary>This value is returned when an update for the application is available, and the update is required.</summary>
    Required,
    /// <summary>This value is returned when an error is encountered.</summary>
    Error,
  }
}

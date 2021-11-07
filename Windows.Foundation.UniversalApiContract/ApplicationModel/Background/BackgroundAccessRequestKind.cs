// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundAccessRequestKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies the level of background activity that an app can request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum BackgroundAccessRequestKind
  {
    /// <summary>Allow the app run background activities, including during Battery Saver.</summary>
    AlwaysAllowed,
    /// <summary>Allow the app to run in the background, unless background activity has been limited by the user or by the system to improve battery life.</summary>
    AllowedSubjectToSystemPolicy,
  }
}

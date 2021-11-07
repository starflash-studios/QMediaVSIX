// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.EducationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Indicates if an app is running in an education environment.</summary>
  [Static(typeof (IEducationSettingsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public static class EducationSettings
  {
    /// <summary>Gets a Boolean value indicating if the app is running in an education environment.</summary>
    /// <returns>A Boolean value indicating if the app is running in an education environment.</returns>
    public static extern bool IsEducationEnvironment { [MethodImpl] get; }
  }
}

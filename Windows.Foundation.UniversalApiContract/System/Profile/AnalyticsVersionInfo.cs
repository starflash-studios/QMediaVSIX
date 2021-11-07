// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.AnalyticsVersionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides version information about the device family.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AnalyticsVersionInfo : IAnalyticsVersionInfo, IAnalyticsVersionInfo2
  {
    /// <summary>Gets a string that represents the type of device the application is running on.</summary>
    /// <returns>The device family.</returns>
    public extern string DeviceFamily { [MethodImpl] get; }

    /// <summary>Gets the version within the device family.</summary>
    /// <returns>The version within the device family.</returns>
    public extern string DeviceFamilyVersion { [MethodImpl] get; }

    public extern string ProductName { [MethodImpl] get; }
  }
}

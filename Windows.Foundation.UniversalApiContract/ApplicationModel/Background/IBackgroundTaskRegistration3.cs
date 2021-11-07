// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a background task that has been registered as part of a group of related background tasks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4264788373, 37923, 19851, 131, 13, 177, 221, 44, 123, 173, 213)]
  public interface IBackgroundTaskRegistration3 : IBackgroundTaskRegistration
  {
    /// <summary>Gets the BackgroundTaskRegistrationGroup that this **BackgroundTaskRegistration** is a part of.</summary>
    /// <returns>The **BackgroundTaskRegistrationGroup** that this BackgroundTaskRegistration is a part of.</returns>
    BackgroundTaskRegistrationGroup TaskGroup { get; }
  }
}

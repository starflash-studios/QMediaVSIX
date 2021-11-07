// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskInstance2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides access to a background task instance. Inherits from the IBackgroundTaskInstance interface and adds the GetThrottleCount method.</summary>
  [Guid(1333592438, 3190, 20404, 137, 109, 93, 225, 134, 65, 34, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTaskInstance2 : IBackgroundTaskInstance
  {
    /// <summary>Retrieves the number of times the background task has been suspended for using too many resources.</summary>
    /// <param name="counter">Indicates the type of resource to include in the throttle count: network, CPU, or both.</param>
    /// <returns>This method returns the number of times the background task has been suspended for exceeding its quota of the indicated resource type.</returns>
    uint GetThrottleCount(BackgroundTaskThrottleCounter counter);
  }
}

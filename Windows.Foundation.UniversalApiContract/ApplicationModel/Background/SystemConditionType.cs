// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemConditionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies a system condition that must be in effect for a background task to run. If a background task with a system condition is triggered, the task will not run until the condition is met.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SystemConditionType
  {
    /// <summary>Not a valid condition type.</summary>
    Invalid,
    /// <summary>Specifies that the background task can only run when the user is present. If a background task with the **UserPresent** condition is triggered, and the user is away, the task will not run until the user is present.</summary>
    UserPresent,
    /// <summary>Specifies that background task can only run when the user is not present. If a background task with the **UserNotPresent** condition is triggered, and the user is present, the task will not run until the user becomes inactive.</summary>
    UserNotPresent,
    /// <summary>Specifies that the background task can only run when the Internet is available. If a background task with the **InternetAvailable** condition is triggered, and the Internet is not available, the task will not run until the Internet is available again. This condition saves power because the background task won't execute until the network is available. This condition does not provide real-time activation.</summary>
    InternetAvailable,
    /// <summary>Specifies that the background task can only run when the Internet is not available. If a background task with the **InternetNotAvailable** condition is triggered, and the Internet is available, the task will not run until the Internet is unavailable.</summary>
    InternetNotAvailable,
    /// <summary>Specifies that the background task can only run when the user's session is connected. If a background task with the **SessionConnected** condition is triggered, and the user session is not logged in, the task will run when the user logs in.</summary>
    SessionConnected,
    /// <summary>Specifies that the background task can only run when the user's session is disconnected. If a background task with the **SessionDisconnected** condition is triggered, and the user is logged in, the task will run when the user disconnects the remote desktop session or does fast user switching&gt; [!NOTE]</summary>
    SessionDisconnected,
    /// <summary>Specifies that the background task can only run when a free (non-metered) network connection is available.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] FreeNetworkAvailable,
    /// <summary>Specifies that the background task can only run when the cost to do background work is low.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BackgroundWorkCostNotHigh,
  }
}

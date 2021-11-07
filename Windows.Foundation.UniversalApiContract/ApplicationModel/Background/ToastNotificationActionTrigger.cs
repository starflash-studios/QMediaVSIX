// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ToastNotificationActionTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that causes a background task to run when the user performs an action on an interactive toast notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IToastNotificationActionTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ToastNotificationActionTrigger : IBackgroundTrigger
  {
    /// <summary>Creates and initializes a new instance of the ToastNotificationActionTrigger class for the app with the specified identifier.</summary>
    /// <param name="applicationId">The identifier of the app for which you want to create an instance of the ToastNotificationActionTrigger class.</param>
    [MethodImpl]
    public extern ToastNotificationActionTrigger(string applicationId);

    /// <summary>Creates and initializes a new instance of the ToastNotificationActionTrigger class.</summary>
    [MethodImpl]
    public extern ToastNotificationActionTrigger();
  }
}

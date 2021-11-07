// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.PushNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an object that invokes a background work item on the app in response to the receipt of a raw notification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPushNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class PushNotificationTrigger : IBackgroundTrigger
  {
    /// <summary>Invokes a background work item on a specified app in response to the receipt of a raw notification.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    [MethodImpl]
    public extern PushNotificationTrigger(string applicationId);

    /// <summary>Invokes a background work item on the app in response to the receipt of a raw notification.</summary>
    [MethodImpl]
    public extern PushNotificationTrigger();
  }
}

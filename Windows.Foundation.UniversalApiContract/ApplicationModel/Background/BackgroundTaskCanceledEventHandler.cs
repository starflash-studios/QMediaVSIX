// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a method that handles the cancellation of a background task.</summary>
  /// <param name="sender">The background task instance that was cancelled.</param>
  /// <param name="reason">The reason the background task instance was cancelled.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2797910720, 20984, 19543, 172, 63, 21, 109, 209, 104, 12, 79)]
  public delegate void BackgroundTaskCanceledEventHandler(
    IBackgroundTaskInstance sender,
    BackgroundTaskCancellationReason reason);
}

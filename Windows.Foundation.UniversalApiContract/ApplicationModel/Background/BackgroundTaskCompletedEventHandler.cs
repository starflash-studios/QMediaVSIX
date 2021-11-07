// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a method that handles completion events for a background task.</summary>
  /// <param name="sender">The background task.</param>
  /// <param name="args">Completion information for the task at the time the notification is sent.</param>
  [Guid(1530456361, 41094, 18087, 166, 120, 67, 145, 53, 130, 43, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void BackgroundTaskCompletedEventHandler(
    BackgroundTaskRegistration sender,
    BackgroundTaskCompletedEventArgs args);
}

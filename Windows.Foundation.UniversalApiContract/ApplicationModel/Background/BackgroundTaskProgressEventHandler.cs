// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a method that handles progress update events for a background task.</summary>
  /// <param name="sender">The background task.</param>
  /// <param name="args">Progress information for the task at the time the notification is sent.</param>
  [Guid(1189111868, 35464, 19609, 128, 76, 118, 137, 127, 98, 119, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void BackgroundTaskProgressEventHandler(
    BackgroundTaskRegistration sender,
    BackgroundTaskProgressEventArgs args);
}

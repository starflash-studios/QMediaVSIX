// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.BackgroundActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Makes all data available from the IBackgroundTask.Run method available to your event handler when your app is activated by a background trigger.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class BackgroundActivatedEventArgs : IBackgroundActivatedEventArgs
  {
    /// <summary>Gets the background task that activated the app.</summary>
    /// <returns>The background task that activated the app.</returns>
    public extern IBackgroundTaskInstance TaskInstance { [MethodImpl] get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IBackgroundActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Makes all data available from the IBackgroundTask.Run method available to your event handler when your app is activated by a background trigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2870263520, 59232, 17422, 169, 28, 68, 121, 109, 227, 169, 45)]
  public interface IBackgroundActivatedEventArgs
  {
    /// <summary>Get the data that was available to the IBackgroundTask.Run method that resulted in your app being activated.</summary>
    /// <returns>The data that was available to the IBackgroundTask.Run method.</returns>
    IBackgroundTaskInstance TaskInstance { get; }
  }
}

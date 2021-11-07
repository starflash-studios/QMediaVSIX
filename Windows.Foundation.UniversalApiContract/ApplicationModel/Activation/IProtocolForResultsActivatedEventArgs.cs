// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolForResultsActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Describes the activation arguments when an app is launched via LaunchUriForResultsAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3880858306, 31463, 17687, 128, 172, 219, 232, 215, 204, 91, 156)]
  public interface IProtocolForResultsActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the **ProtocolForResultsOperation** that you can then use to signal that your app is ready to return to the app that launched it for results.</summary>
    /// <returns>The **ProtocolForResultsOperation** object that you can use to signal that your app is ready to return by calling its ProtocolForResultsOperation.ReportCompleted method.</returns>
    ProtocolForResultsOperation ProtocolForResultsOperation { get; }
  }
}

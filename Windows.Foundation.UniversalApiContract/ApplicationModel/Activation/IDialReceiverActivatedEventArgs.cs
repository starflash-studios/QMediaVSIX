// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDialReceiverActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated from another app by using the DIAL protocol.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4218912471, 34286, 17774, 164, 77, 133, 215, 48, 231, 10, 237)]
  public interface IDialReceiverActivatedEventArgs : ILaunchActivatedEventArgs, IActivatedEventArgs
  {
    /// <summary>Gets the name of the app that invoked the dial receiver app.</summary>
    /// <returns>The name of the app that invoked the dial receiver app.</returns>
    string AppName { get; }
  }
}

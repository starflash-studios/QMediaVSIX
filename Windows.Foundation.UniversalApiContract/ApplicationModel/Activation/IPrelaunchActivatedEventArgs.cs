// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IPrelaunchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides event information about whether an app is in pre-launch state.</summary>
  [Guid(205812091, 6647, 18646, 176, 70, 207, 34, 130, 110, 170, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrelaunchActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets an indication about whether a pre-launch has been activated.</summary>
    /// <returns>Indicates whether a pre-launch has been activated. **TRUE** indicates activated; otherwise, **FALSE**.</returns>
    bool PrelaunchActivated { get; }
  }
}

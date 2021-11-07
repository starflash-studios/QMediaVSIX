// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISynchronizedInputProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Enables Microsoft UI Automation client applications to direct the mouse or keyboard input to a specific UI element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1029754571, 55892, 19107, 185, 21, 227, 36, 68, 39, 212, 172)]
  public interface ISynchronizedInputProvider
  {
    /// <summary>Cancels listening for input.</summary>
    void Cancel();

    /// <summary>Starts listening for input of the specified type.</summary>
    /// <param name="inputType">The type of input that is requested to be synchronized.</param>
    void StartListening(SynchronizedInputType inputType);
  }
}

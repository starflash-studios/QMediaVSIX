// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IInvokeProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes a method to support Microsoft UI Automation access to controls that initiate or perform a single, unambiguous action and do not maintain state when activated. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Invoke.</summary>
  [WebHostHidden]
  [Guid(4157710727, 45372, 17728, 176, 158, 103, 120, 226, 220, 155, 165)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInvokeProvider
  {
    /// <summary>Sends a request to initiate or perform the single, unambiguous action of the provider control. For example, the invoke action for a Button is click.</summary>
    void Invoke();
  }
}

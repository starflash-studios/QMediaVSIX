// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by Microsoft UI Automation client to individual child controls of containers that implement IScrollProvider. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.ScrollItem.</summary>
  [Guid(2587803792, 23852, 20034, 158, 230, 157, 88, 219, 16, 11, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IScrollItemProvider
  {
    /// <summary>Scrolls the content area of a container object in order to display the control within the visible region (viewport) of the container.</summary>
    void ScrollIntoView();
  }
}

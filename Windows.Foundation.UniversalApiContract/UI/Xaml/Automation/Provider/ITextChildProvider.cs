// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextChildProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Provides access to a text-based control that is a child of another text-based control. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.TextChild.</summary>
  [Guid(288604982, 43163, 16688, 155, 230, 85, 227, 51, 52, 245, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ITextChildProvider
  {
    /// <summary>Gets this element's nearest ancestor provider that supports the **Text** (ITextProvider ) control pattern.</summary>
    /// <returns>The nearest ancestor provider that supports the **Text** (ITextProvider ) control pattern.</returns>
    IRawElementProviderSimple TextContainer { get; }

    /// <summary>Gets a text range that encloses this child element.</summary>
    /// <returns>A text range that encloses this child element.</returns>
    ITextRangeProvider TextRange { get; }
  }
}

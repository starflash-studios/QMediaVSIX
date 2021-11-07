// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IValueProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that have an intrinsic value that does not span a range and that can be represented as a string. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Value.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(545699751, 44046, 18385, 171, 155, 42, 100, 41, 42, 253, 248)]
  [WebHostHidden]
  public interface IValueProvider
  {
    /// <summary>Gets a value that indicates whether the value of a control is read-only.</summary>
    /// <returns>**true** if the value is read-only; **false** if it can be modified.</returns>
    bool IsReadOnly { get; }

    /// <summary>Gets the value of the control.</summary>
    /// <returns>The value of the control.</returns>
    string Value { get; }

    /// <summary>Sets the value of a control.</summary>
    /// <param name="value">The value to set. The provider is responsible for converting the value to the appropriate data type.</param>
    void SetValue(string value);
  }
}

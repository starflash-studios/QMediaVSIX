// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IRangeValueProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that can be set to a value within a range. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.RangeValue.</summary>
  [Guid(2206872744, 32095, 16505, 175, 3, 195, 208, 21, 233, 52, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IRangeValueProvider
  {
    /// <summary>Gets a value that indicates whether the value of a control is read-only.</summary>
    /// <returns>**true** if the value is read-only; **false** if it can be modified.</returns>
    bool IsReadOnly { get; }

    /// <summary>Gets the value that is added to or subtracted from the Value property when a large change is made, such as with the PAGE DOWN key.</summary>
    /// <returns>The large-change value that is supported by the control, or null if the control does not support LargeChange.</returns>
    double LargeChange { get; }

    /// <summary>Gets the maximum range value that is supported by the control.</summary>
    /// <returns>The maximum value that is supported by the control, or null if the control does not support Maximum.</returns>
    double Maximum { get; }

    /// <summary>Gets the minimum range value that is supported by the control.</summary>
    /// <returns>The minimum value that is supported by the control, or null if the control does not support Minimum.</returns>
    double Minimum { get; }

    /// <summary>Gets the value that is added to or subtracted from the Value property when a small change is made, such as with an arrow key.</summary>
    /// <returns>The small-change value supported by the control, or null if the control does not support SmallChange.</returns>
    double SmallChange { get; }

    /// <summary>Gets the value of the control.</summary>
    /// <returns>The value of the control, or null if the control does not support Value.</returns>
    double Value { get; }

    /// <summary>Sets the value of the control.</summary>
    /// <param name="value">The value to set.</param>
    void SetValue(double value);
  }
}

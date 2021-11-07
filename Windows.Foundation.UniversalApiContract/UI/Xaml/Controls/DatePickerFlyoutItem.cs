// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickerFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container for an item in the DatePickerFlyout control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDatePickerFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class DatePickerFlyoutItem : 
    DependencyObject,
    IDatePickerFlyoutItem,
    ICustomPropertyProvider
  {
    /// <summary>Gets or sets the primary text of the item.</summary>
    /// <returns>The primary text of the item.</returns>
    public extern string PrimaryText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the secondary text of the item.</summary>
    /// <returns>The secondary text of the item.</returns>
    public extern string SecondaryText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves an ICustomProperty object by specifying a property name.</summary>
    /// <param name="name">The name of the property.</param>
    /// <returns>The custom property support object.</returns>
    [MethodImpl]
    public extern ICustomProperty GetCustomProperty(string name);

    [MethodImpl]
    public extern ICustomProperty GetIndexedProperty(string name, TypeName type);

    /// <summary>Provides support for "GetStringFromObject" and/or "ToString" logic on the assumption that the implementation supports System.Object. This logic might be accessed by features or services such as generating UI Automation values based on data content.</summary>
    /// <returns>The provided string.</returns>
    [MethodImpl]
    public extern string GetStringRepresentation();

    /// <summary>Gets the type of the item.</summary>
    /// <returns>The type of the item, specified as a TypeName wrapper.</returns>
    public extern TypeName Type { [MethodImpl] get; }

    /// <summary>Identifies the PrimaryText dependency property.</summary>
    /// <returns>The identifier for the PrimaryText dependency property.</returns>
    public static extern DependencyProperty PrimaryTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the SecondaryText dependency property.</summary>
    /// <returns>The identifier for the SecondaryText dependency property.</returns>
    public static extern DependencyProperty SecondaryTextProperty { [MethodImpl] get; }
  }
}

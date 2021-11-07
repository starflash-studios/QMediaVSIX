// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PropertyMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines behavior aspects of a dependency property, including conditions it was registered with. For more info on how PropertyMetadata is used for dependency properties, see Custom dependency properties.</summary>
  [Composable(typeof (IPropertyMetadataFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPropertyMetadataStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class PropertyMetadata : IPropertyMetadata
  {
    /// <summary>Initializes a new instance of the PropertyMetadata class, using a property default value.</summary>
    /// <param name="defaultValue">A default value for the property where this PropertyMetadata is applied.</param>
    [MethodImpl]
    public extern PropertyMetadata(object defaultValue);

    /// <summary>Initializes a new instance of the PropertyMetadata class, using a property default value and callback reference.</summary>
    /// <param name="defaultValue">A default value for the property where this PropertyMetadata is applied.</param>
    /// <param name="propertyChangedCallback">A reference to the callback to call for property changed behavior.</param>
    [MethodImpl]
    public extern PropertyMetadata(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    /// <summary>Gets the default value for the dependency property.</summary>
    /// <returns>The default value for the dependency property.</returns>
    public extern object DefaultValue { [MethodImpl] get; }

    /// <summary>Gets a reference to the callback method that provides a default property value.</summary>
    /// <returns>A reference to the callback method that provides a default property value.</returns>
    public extern CreateDefaultValueCallback CreateDefaultValueCallback { [MethodImpl] get; }

    /// <summary>Creates a PropertyMetadata value, specifying a fixed default value for a dependency property.</summary>
    /// <param name="defaultValue">The dependency property default value to apply.</param>
    /// <returns>The newly created dependency property metadata.</returns>
    [DefaultOverload]
    [Overload("CreateWithDefaultValue")]
    [MethodImpl]
    public static extern PropertyMetadata Create(object defaultValue);

    /// <summary>Creates a PropertyMetadata value, specifying a fixed default value for a dependency property, and a property-changed callback.</summary>
    /// <param name="defaultValue">The dependency property default value to apply.</param>
    /// <param name="propertyChangedCallback">A reference to the callback method that is invoked by the property system when a dependency property value changes.</param>
    /// <returns>The newly created dependency property metadata.</returns>
    [DefaultOverload]
    [Overload("CreateWithDefaultValueAndCallback")]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    /// <summary>Creates a PropertyMetadata value, specifying a callback that establishes a default value for a dependency property.</summary>
    /// <param name="createDefaultValueCallback">A reference to the callback method that provides a default property value.</param>
    /// <returns>The newly created dependency property metadata.</returns>
    [Overload("CreateWithFactory")]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback);

    /// <summary>Creates a PropertyMetadata value, specifying a callback that establishes a default value for a dependency property, and a property-changed callback.</summary>
    /// <param name="createDefaultValueCallback">A reference to the callback method that provides a default property value.</param>
    /// <param name="propertyChangedCallback">A reference to the callback method that is invoked by the property system when a dependency property value changes.</param>
    /// <returns>The newly created dependency property metadata.</returns>
    [Overload("CreateWithFactoryAndCallback")]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback,
      PropertyChangedCallback propertyChangedCallback);
  }
}

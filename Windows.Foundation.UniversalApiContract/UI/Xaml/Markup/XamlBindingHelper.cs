// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlBindingHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides helper methods for data binding.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IXamlBindingHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class XamlBindingHelper : IXamlBindingHelper
  {
    /// <summary>Identifies the DataTemplateComponent attached property.</summary>
    /// <returns>The identifier for the DataTemplateComponent attached property.</returns>
    public static extern DependencyProperty DataTemplateComponentProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the DataTemplateComponent XAML attached property for a target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The DataTemplateComponent XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern IDataTemplateComponent GetDataTemplateComponent(
      DependencyObject element);

    /// <summary>Sets the value of the DataTemplateComponent XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetDataTemplateComponent(
      DependencyObject element,
      IDataTemplateComponent value);

    /// <summary>Suspends rendering of the specified element.</summary>
    /// <param name="target">The element for which to suspend rendering.</param>
    [MethodImpl]
    public static extern void SuspendRendering(UIElement target);

    /// <summary>Resumes rendering of the specified element.</summary>
    /// <param name="target">The element for which to resume rendering.</param>
    [MethodImpl]
    public static extern void ResumeRendering(UIElement target);

    [MethodImpl]
    public static extern object ConvertValue(TypeName type, object value);

    /// <summary>Sets a DependencyProperty from a String value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromString(
      object dependencyObject,
      DependencyProperty propertyToSet,
      string value);

    /// <summary>Sets a DependencyProperty from a Boolean value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromBoolean(
      object dependencyObject,
      DependencyProperty propertyToSet,
      bool value);

    /// <summary>Sets a DependencyProperty from a Char value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromChar16(
      object dependencyObject,
      DependencyProperty propertyToSet,
      char value);

    [MethodImpl]
    public static extern void SetPropertyFromDateTime(
      object dependencyObject,
      DependencyProperty propertyToSet,
      DateTime value);

    /// <summary>Sets a DependencyProperty from a Double value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromDouble(
      object dependencyObject,
      DependencyProperty propertyToSet,
      double value);

    /// <summary>Sets a DependencyProperty from a Int32 value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      int value);

    /// <summary>Sets a DependencyProperty from a UInt32 value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromUInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      uint value);

    /// <summary>Sets a DependencyProperty from a Int64 value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      long value);

    /// <summary>Sets a DependencyProperty from a UInt64 value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromUInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      ulong value);

    /// <summary>Sets a DependencyProperty from a Single value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromSingle(
      object dependencyObject,
      DependencyProperty propertyToSet,
      float value);

    /// <summary>Sets a DependencyProperty from a Point value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromPoint(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Point value);

    /// <summary>Sets a DependencyProperty from a Rect value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromRect(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Rect value);

    /// <summary>Sets a DependencyProperty from a Size value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromSize(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Size value);

    [MethodImpl]
    public static extern void SetPropertyFromTimeSpan(
      object dependencyObject,
      DependencyProperty propertyToSet,
      TimeSpan value);

    /// <summary>Sets a DependencyProperty from a Byte value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromByte(
      object dependencyObject,
      DependencyProperty propertyToSet,
      byte value);

    [MethodImpl]
    public static extern void SetPropertyFromUri(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Uri value);

    /// <summary>Sets a DependencyProperty from a Object value.</summary>
    /// <param name="dependencyObject">The object to which the property being set belongs.</param>
    /// <param name="propertyToSet">The property to which the value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetPropertyFromObject(
      object dependencyObject,
      DependencyProperty propertyToSet,
      object value);
  }
}

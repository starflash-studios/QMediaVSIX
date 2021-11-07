// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlBindingHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XamlBindingHelper))]
  [WebHostHidden]
  [Guid(4133288817, 51212, 20474, 134, 238, 85, 135, 84, 238, 51, 109)]
  internal interface IXamlBindingHelperStatics
  {
    DependencyProperty DataTemplateComponentProperty { get; }

    IDataTemplateComponent GetDataTemplateComponent(DependencyObject element);

    void SetDataTemplateComponent(DependencyObject element, IDataTemplateComponent value);

    void SuspendRendering(UIElement target);

    void ResumeRendering(UIElement target);

    object ConvertValue(TypeName type, object value);

    void SetPropertyFromString(
      object dependencyObject,
      DependencyProperty propertyToSet,
      string value);

    void SetPropertyFromBoolean(
      object dependencyObject,
      DependencyProperty propertyToSet,
      bool value);

    void SetPropertyFromChar16(
      object dependencyObject,
      DependencyProperty propertyToSet,
      char value);

    void SetPropertyFromDateTime(
      object dependencyObject,
      DependencyProperty propertyToSet,
      DateTime value);

    void SetPropertyFromDouble(
      object dependencyObject,
      DependencyProperty propertyToSet,
      double value);

    void SetPropertyFromInt32(object dependencyObject, DependencyProperty propertyToSet, int value);

    void SetPropertyFromUInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      uint value);

    void SetPropertyFromInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      long value);

    void SetPropertyFromUInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      ulong value);

    void SetPropertyFromSingle(
      object dependencyObject,
      DependencyProperty propertyToSet,
      float value);

    void SetPropertyFromPoint(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Point value);

    void SetPropertyFromRect(object dependencyObject, DependencyProperty propertyToSet, Rect value);

    void SetPropertyFromSize(object dependencyObject, DependencyProperty propertyToSet, Size value);

    void SetPropertyFromTimeSpan(
      object dependencyObject,
      DependencyProperty propertyToSet,
      TimeSpan value);

    void SetPropertyFromByte(object dependencyObject, DependencyProperty propertyToSet, byte value);

    void SetPropertyFromUri(object dependencyObject, DependencyProperty propertyToSet, Uri value);

    void SetPropertyFromObject(
      object dependencyObject,
      DependencyProperty propertyToSet,
      object value);
  }
}

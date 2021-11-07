// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2331475315, 43521, 18206, 190, 221, 139, 173, 134, 33, 155, 119)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataTemplate))]
  [WebHostHidden]
  internal interface IDataTemplateStatics2
  {
    DependencyProperty ExtensionInstanceProperty { get; }

    IDataTemplateExtension GetExtensionInstance(FrameworkElement element);

    void SetExtensionInstance(FrameworkElement element, IDataTemplateExtension value);
  }
}

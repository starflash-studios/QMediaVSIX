// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDataTemplateSelectorOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DataTemplateSelector))]
  [Guid(756427045, 22886, 19450, 134, 56, 77, 52, 86, 137, 246, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTemplateSelectorOverrides
  {
    DataTemplate SelectTemplateCore(object item, DependencyObject container);
  }
}

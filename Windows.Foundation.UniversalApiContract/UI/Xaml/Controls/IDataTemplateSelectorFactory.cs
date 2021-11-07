// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDataTemplateSelectorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DataTemplateSelector))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1360767696, 8458, 17789, 149, 33, 67, 61, 43, 17, 183, 210)]
  internal interface IDataTemplateSelectorFactory
  {
    DataTemplateSelector CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}

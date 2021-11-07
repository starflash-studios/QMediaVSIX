// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemTemplateSettingsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TreeViewItemTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(295802171, 12727, 20288, 134, 51, 2, 252, 97, 75, 81, 140)]
  internal interface ITreeViewItemTemplateSettingsFactory
  {
    TreeViewItemTemplateSettings CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeView))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(3427952579, 27753, 18894, 180, 69, 117, 58, 206, 231, 148, 139)]
  internal interface ITreeViewFactory
  {
    TreeView CreateInstance(object baseInterface, out object innerInterface);
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4019273224, 33778, 19990, 191, 177, 21, 119, 185, 131, 85, 245)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TreeView))]
  [WebHostHidden]
  internal interface ITreeViewStatics
  {
    DependencyProperty SelectionModeProperty { get; }
  }
}

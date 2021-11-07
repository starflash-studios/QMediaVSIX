// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewCollapsedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewCollapsedEventArgs))]
  [Guid(1954230095, 31525, 22186, 131, 0, 120, 216, 59, 122, 178, 219)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface ITreeViewCollapsedEventArgs2
  {
    object Item { get; }
  }
}

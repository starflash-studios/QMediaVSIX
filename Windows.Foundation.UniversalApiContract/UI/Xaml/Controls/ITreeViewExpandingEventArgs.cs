// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewExpandingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TreeViewExpandingEventArgs))]
  [Guid(3319921251, 16724, 18898, 162, 31, 195, 65, 118, 96, 94, 58)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ITreeViewExpandingEventArgs
  {
    TreeViewNode Node { get; }
  }
}

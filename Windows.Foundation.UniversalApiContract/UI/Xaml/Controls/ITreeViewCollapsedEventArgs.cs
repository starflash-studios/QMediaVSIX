// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewCollapsedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewCollapsedEventArgs))]
  [Guid(958247856, 7768, 17721, 158, 147, 56, 121, 120, 244, 108, 206)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ITreeViewCollapsedEventArgs
  {
    TreeViewNode Node { get; }
  }
}

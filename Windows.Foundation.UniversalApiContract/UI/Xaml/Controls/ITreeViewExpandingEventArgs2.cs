// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewExpandingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewExpandingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(2704233667, 34745, 22051, 156, 116, 230, 221, 68, 60, 222, 24)]
  internal interface ITreeViewExpandingEventArgs2
  {
    object Item { get; }
  }
}

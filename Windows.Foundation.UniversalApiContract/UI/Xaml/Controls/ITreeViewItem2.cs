// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TreeViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(8105855, 1171, 20916, 135, 156, 69, 128, 36, 179, 65, 73)]
  internal interface ITreeViewItem2
  {
    bool HasUnrealizedChildren { get; set; }

    object ItemsSource { get; set; }
  }
}

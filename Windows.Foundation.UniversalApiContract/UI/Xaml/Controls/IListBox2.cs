// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBox2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1884760762, 35537, 16517, 147, 80, 222, 238, 53, 146, 148, 227)]
  [ExclusiveTo(typeof (ListBox))]
  [WebHostHidden]
  internal interface IListBox2
  {
    bool SingleSelectionFollowsFocus { get; set; }
  }
}

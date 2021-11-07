// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemClickEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2620473922, 62106, 18765, 163, 165, 212, 199, 178, 164, 104, 82)]
  [WebHostHidden]
  internal interface IItemClickEventArgs
  {
    object ClickedItem { get; }
  }
}

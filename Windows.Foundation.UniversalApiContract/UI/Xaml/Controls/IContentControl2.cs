// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1697390732, 36047, 17305, 189, 62, 90, 1, 90, 161, 188, 3)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentControl))]
  internal interface IContentControl2
  {
    UIElement ContentTemplateRoot { get; }
  }
}

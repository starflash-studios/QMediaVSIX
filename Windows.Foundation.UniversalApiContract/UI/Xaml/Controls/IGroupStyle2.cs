// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyle2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1777927801, 14865, 20455, 180, 223, 42, 1, 57, 212, 1, 139)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GroupStyle))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGroupStyle2
  {
    Style HeaderContainerStyle { get; set; }
  }
}

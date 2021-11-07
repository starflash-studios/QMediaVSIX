// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ControlTemplate))]
  [WebHostHidden]
  [Guid(4023533966, 16864, 18619, 139, 130, 145, 237, 161, 186, 63, 226)]
  internal interface IControlTemplate
  {
    TypeName TargetType { get; set; }
  }
}

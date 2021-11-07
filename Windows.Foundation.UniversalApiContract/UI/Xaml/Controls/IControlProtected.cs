// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(395401338, 10876, 18817, 162, 216, 171, 153, 255, 252, 101, 185)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  internal interface IControlProtected
  {
    object DefaultStyleKey { get; set; }

    DependencyObject GetTemplateChild(string childName);
  }
}

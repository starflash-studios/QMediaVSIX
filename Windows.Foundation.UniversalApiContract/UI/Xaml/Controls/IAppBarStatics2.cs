// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(572741097, 900, 18910, 135, 56, 223, 201, 212, 9, 172, 93)]
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  internal interface IAppBarStatics2
  {
    DependencyProperty ClosedDisplayModeProperty { get; }
  }
}

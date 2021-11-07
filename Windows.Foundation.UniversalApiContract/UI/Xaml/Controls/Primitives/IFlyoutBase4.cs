// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(3817438569, 41855, 18472, 155, 112, 14, 246, 124, 3, 181, 248)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (FlyoutBase))]
  internal interface IFlyoutBase4
  {
    void TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args);
  }
}

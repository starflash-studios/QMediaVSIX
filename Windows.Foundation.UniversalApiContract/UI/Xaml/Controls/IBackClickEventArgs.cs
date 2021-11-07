// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBackClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(719721580, 18302, 18633, 136, 48, 44, 70, 75, 124, 113, 4)]
  [ExclusiveTo(typeof (BackClickEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackClickEventArgs
  {
    bool Handled { get; set; }
  }
}

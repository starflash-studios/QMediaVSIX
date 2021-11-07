// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFocusEngagedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1247404276, 34752, 19661, 147, 196, 163, 160, 28, 227, 146, 101)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (FocusEngagedEventArgs))]
  internal interface IFocusEngagedEventArgs2
  {
    bool Handled { get; set; }
  }
}

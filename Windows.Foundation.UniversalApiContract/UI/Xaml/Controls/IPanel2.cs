// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPanel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(1888564167, 14579, 20611, 164, 187, 6, 165, 72, 161, 210, 49)]
  [ExclusiveTo(typeof (Panel))]
  internal interface IPanel2
  {
    BrushTransition BackgroundTransition { get; set; }
  }
}

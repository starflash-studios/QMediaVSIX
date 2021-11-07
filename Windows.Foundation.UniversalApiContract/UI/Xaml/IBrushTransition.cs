// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBrushTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BrushTransition))]
  [Guid(286693164, 40365, 21545, 167, 221, 178, 183, 208, 97, 171, 142)]
  internal interface IBrushTransition
  {
    TimeSpan Duration { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICandidateWindowBoundsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2324980824, 33712, 19506, 148, 80, 81, 105, 165, 131, 139, 85)]
  [ExclusiveTo(typeof (CandidateWindowBoundsChangedEventArgs))]
  internal interface ICandidateWindowBoundsChangedEventArgs
  {
    Rect Bounds { get; }
  }
}

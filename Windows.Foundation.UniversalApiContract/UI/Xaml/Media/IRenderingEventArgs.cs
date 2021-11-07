// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRenderingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1542968077, 38728, 19181, 131, 128, 215, 137, 14, 183, 118, 160)]
  [ExclusiveTo(typeof (RenderingEventArgs))]
  internal interface IRenderingEventArgs
  {
    TimeSpan RenderingTime { get; }
  }
}

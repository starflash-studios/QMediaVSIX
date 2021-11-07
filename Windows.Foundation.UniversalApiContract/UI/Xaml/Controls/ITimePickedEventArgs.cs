// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2329149217, 24422, 18309, 185, 153, 36, 254, 243, 159, 182, 219)]
  [ExclusiveTo(typeof (TimePickedEventArgs))]
  internal interface ITimePickedEventArgs
  {
    TimeSpan OldTime { get; }

    TimeSpan NewTime { get; }
  }
}

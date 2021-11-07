// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDurationHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163031870, 13639, 20160, 181, 25, 255, 168, 249, 196, 131, 140)]
  [ExclusiveTo(typeof (DurationHelper))]
  internal interface IDurationHelperStatics
  {
    Duration Automatic { get; }

    Duration Forever { get; }

    int Compare(Duration duration1, Duration duration2);

    Duration FromTimeSpan(TimeSpan timeSpan);

    bool GetHasTimeSpan(Duration target);

    Duration Add(Duration target, Duration duration);

    bool Equals(Duration target, Duration value);

    Duration Subtract(Duration target, Duration duration);
  }
}

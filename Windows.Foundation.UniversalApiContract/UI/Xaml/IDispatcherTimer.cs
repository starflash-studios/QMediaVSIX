// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDispatcherTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3512782406, 52514, 20319, 140, 151, 64, 230, 29, 163, 226, 220)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DispatcherTimer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDispatcherTimer
  {
    TimeSpan Interval { get; set; }

    bool IsEnabled { get; }

    event EventHandler<object> Tick;

    void Start();

    void Stop();
  }
}

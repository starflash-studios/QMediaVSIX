// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerSelectedValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1847655221, 15259, 23478, 152, 136, 38, 101, 36, 219, 24, 30)]
  [ExclusiveTo(typeof (TimePickerSelectedValueChangedEventArgs))]
  [WebHostHidden]
  internal interface ITimePickerSelectedValueChangedEventArgs
  {
    IReference<TimeSpan> OldTime { get; }

    IReference<TimeSpan> NewTime { get; }
  }
}

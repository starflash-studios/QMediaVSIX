// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RatingControl))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(2816023719, 58831, 18787, 162, 78, 150, 115, 254, 95, 253, 213)]
  internal interface IRatingControl
  {
    string Caption { get; set; }

    int InitialSetValue { get; set; }

    bool IsClearEnabled { get; set; }

    bool IsReadOnly { get; set; }

    int MaxRating { get; set; }

    double PlaceholderValue { get; set; }

    RatingItemInfo ItemInfo { get; set; }

    double Value { get; set; }

    event TypedEventHandler<RatingControl, object> ValueChanged;
  }
}

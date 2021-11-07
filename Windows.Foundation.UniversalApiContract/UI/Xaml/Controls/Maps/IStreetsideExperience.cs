// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsideExperience
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (StreetsideExperience))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2774052553, 58124, 18120, 129, 22, 72, 70, 145, 103, 85, 88)]
  internal interface IStreetsideExperience
  {
    bool AddressTextVisible { get; set; }

    bool CursorVisible { get; set; }

    bool OverviewMapVisible { get; set; }

    bool StreetLabelsVisible { get; set; }

    bool ExitButtonVisible { get; set; }

    bool ZoomButtonsVisible { get; set; }
  }
}

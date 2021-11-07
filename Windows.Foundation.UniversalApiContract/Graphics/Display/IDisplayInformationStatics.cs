// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3332385388, 54354, 17628, 186, 7, 150, 243, 198, 173, 249, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DisplayInformation))]
  internal interface IDisplayInformationStatics
  {
    DisplayInformation GetForCurrentView();

    DisplayOrientations AutoRotationPreferences { get; set; }

    event TypedEventHandler<DisplayInformation, object> DisplayContentsInvalidated;
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2039844715, 12899, 17013, 133, 214, 174, 174, 137, 28, 150, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FocusSettings))]
  internal interface IFocusSettings
  {
    FocusMode Mode { get; set; }

    AutoFocusRange AutoFocusRange { get; set; }

    IReference<uint> Value { get; set; }

    IReference<ManualFocusDistance> Distance { get; set; }

    bool WaitForFocus { get; set; }

    bool DisableDriverFallback { get; set; }
  }
}

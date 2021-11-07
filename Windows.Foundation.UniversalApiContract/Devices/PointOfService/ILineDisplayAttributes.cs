// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayAttributes))]
  [Guid(3246254492, 8858, 19476, 166, 241, 180, 228, 177, 254, 173, 146)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ILineDisplayAttributes
  {
    bool IsPowerNotifyEnabled { get; set; }

    int Brightness { get; set; }

    TimeSpan BlinkRate { get; set; }

    Size ScreenSizeInCharacters { get; set; }

    int CharacterSet { get; set; }

    bool IsCharacterSetMappingEnabled { get; set; }

    LineDisplayWindow CurrentWindow { get; set; }
  }
}

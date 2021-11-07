// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3379744303, 4674, 18110, 181, 54, 225, 170, 254, 158, 122, 207)]
  [ExclusiveTo(typeof (DisplayInformation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDisplayInformation4
  {
    uint ScreenWidthInRawPixels { get; }

    uint ScreenHeightInRawPixels { get; }
  }
}

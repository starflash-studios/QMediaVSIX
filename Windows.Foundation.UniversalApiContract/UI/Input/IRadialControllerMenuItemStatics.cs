// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input
{
  [Guid(614336647, 55362, 17700, 157, 248, 224, 214, 71, 237, 200, 135)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  internal interface IRadialControllerMenuItemStatics
  {
    RadialControllerMenuItem CreateFromIcon(
      string displayText,
      RandomAccessStreamReference icon);

    RadialControllerMenuItem CreateFromKnownIcon(
      string displayText,
      RadialControllerMenuKnownIcon value);
  }
}

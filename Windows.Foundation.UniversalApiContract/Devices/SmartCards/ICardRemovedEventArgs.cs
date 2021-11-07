// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ICardRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (CardRemovedEventArgs))]
  [Guid(355670703, 8919, 18757, 175, 201, 3, 180, 111, 66, 166, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICardRemovedEventArgs
  {
    SmartCard SmartCard { get; }
  }
}

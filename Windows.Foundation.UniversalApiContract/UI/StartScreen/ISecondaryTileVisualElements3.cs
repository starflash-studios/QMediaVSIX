// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileVisualElements3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTileVisualElements))]
  [Guid(1454725846, 53596, 16628, 129, 231, 87, 255, 216, 248, 164, 233)]
  internal interface ISecondaryTileVisualElements3
  {
    Uri Square44x44Logo { set; get; }
  }
}

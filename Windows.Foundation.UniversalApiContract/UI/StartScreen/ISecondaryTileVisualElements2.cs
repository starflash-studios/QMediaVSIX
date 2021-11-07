// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileVisualElements2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (SecondaryTileVisualElements))]
  [Guid(4247663056, 22492, 18324, 142, 207, 86, 130, 245, 243, 230, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISecondaryTileVisualElements2
  {
    Uri Square71x71Logo { set; get; }
  }
}

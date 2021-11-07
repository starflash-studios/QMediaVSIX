// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(3002518581, 12880, 18832, 146, 60, 41, 74, 180, 182, 148, 221)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTile2 : ISecondaryTile
  {
    string PhoneticName { set; get; }

    SecondaryTileVisualElements VisualElements { get; }

    bool RoamingEnabled { set; get; }

    event TypedEventHandler<SecondaryTile, VisualElementsRequestedEventArgs> VisualElementsRequested;
  }
}

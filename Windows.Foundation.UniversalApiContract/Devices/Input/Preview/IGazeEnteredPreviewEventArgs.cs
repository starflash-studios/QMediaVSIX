// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.IGazeEnteredPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  [Guid(627556163, 4645, 18591, 157, 209, 218, 167, 197, 15, 191, 75)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (GazeEnteredPreviewEventArgs))]
  internal interface IGazeEnteredPreviewEventArgs
  {
    bool Handled { get; set; }

    GazePointPreview CurrentPoint { get; }
  }
}

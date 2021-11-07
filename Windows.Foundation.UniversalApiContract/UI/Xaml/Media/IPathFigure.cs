// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathFigure
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PathFigure))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1570069644, 24489, 19930, 163, 204, 16, 252, 220, 170, 32, 215)]
  internal interface IPathFigure
  {
    PathSegmentCollection Segments { get; set; }

    Point StartPoint { get; set; }

    bool IsClosed { get; set; }

    bool IsFilled { get; set; }
  }
}

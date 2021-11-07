// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowPlacement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (AppWindowPlacement))]
  [Guid(64782686, 59305, 22615, 156, 3, 125, 103, 5, 148, 65, 14)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppWindowPlacement
  {
    DisplayRegion DisplayRegion { get; }

    Point Offset { get; }

    Size Size { get; }
  }
}

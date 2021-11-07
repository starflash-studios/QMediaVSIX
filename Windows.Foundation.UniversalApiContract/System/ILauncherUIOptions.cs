// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.System
{
  [ExclusiveTo(typeof (LauncherUIOptions))]
  [Guid(455465582, 35494, 16873, 130, 81, 65, 101, 245, 152, 95, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILauncherUIOptions
  {
    IReference<Point> InvocationPoint { get; set; }

    IReference<Rect> SelectionRect { get; set; }

    Placement PreferredPlacement { get; set; }
  }
}

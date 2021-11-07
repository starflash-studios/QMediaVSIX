// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubSection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (HubSection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2766564535, 32733, 20448, 171, 73, 194, 70, 99, 157, 204, 249)]
  internal interface IHubSection
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    DataTemplate ContentTemplate { get; set; }

    bool IsHeaderInteractive { get; set; }
  }
}

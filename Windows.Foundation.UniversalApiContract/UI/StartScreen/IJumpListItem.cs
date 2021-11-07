// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2061199127, 35677, 18464, 153, 91, 155, 65, 141, 190, 72, 176)]
  [ExclusiveTo(typeof (JumpListItem))]
  internal interface IJumpListItem
  {
    JumpListItemKind Kind { get; }

    string Arguments { get; }

    bool RemovedByUser { get; }

    string Description { get; set; }

    string DisplayName { get; set; }

    string GroupName { get; set; }

    Uri Logo { get; set; }
  }
}

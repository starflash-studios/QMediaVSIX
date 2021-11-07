// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2955103294, 52591, 19638, 166, 17, 97, 253, 80, 95, 62, 209)]
  [ExclusiveTo(typeof (JumpList))]
  internal interface IJumpList
  {
    IVector<JumpListItem> Items { get; }

    JumpListSystemGroupKind SystemGroupKind { get; set; }

    [RemoteAsync]
    IAsyncAction SaveAsync();
  }
}

// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2816525953, 59006, 19316, 130, 80, 63, 50, 44, 77, 146, 195)]
  [ExclusiveTo(typeof (JumpList))]
  internal interface IJumpListStatics
  {
    [RemoteAsync]
    IAsyncOperation<JumpList> LoadCurrentAsync();

    bool IsSupported();
  }
}

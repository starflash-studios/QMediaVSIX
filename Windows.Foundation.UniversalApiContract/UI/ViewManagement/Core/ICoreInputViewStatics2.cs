// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [Guid(2126252130, 53321, 20050, 135, 176, 30, 144, 233, 140, 73, 237)]
  [ExclusiveTo(typeof (CoreInputView))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICoreInputViewStatics2
  {
    CoreInputView GetForUIContext(UIContext context);
  }
}

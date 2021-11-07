// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusMovementResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FocusMovementResult))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(115337939, 49838, 17595, 191, 171, 156, 115, 222, 132, 7, 164)]
  internal interface IFocusMovementResult
  {
    bool Succeeded { get; }
  }
}
